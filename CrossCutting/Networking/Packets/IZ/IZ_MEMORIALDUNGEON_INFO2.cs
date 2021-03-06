﻿using System;
using System.IO;
using Aegis.CrossCutting.GlobalDataClasses;
using Aegis.CrossCutting.Network.Classes;

namespace Aegis.CrossCutting.Network.Packets.IZ
{
    [Command(PACKET_COMMAND.IZ_MEMORIALDUNGEON_INFO2)]
    public class IZ_MEMORIALDUNGEON_INFO2 : PacketVarSize
    {
        public int AID { get; set; }
        public int GID { get; set; }
        public int DestroyDate { get; set; }
        public int EnterTimeOutDate { get; set; }
        public string DungeonName { get; set; }

        public IZ_MEMORIALDUNGEON_INFO2()
        {
            Command = (ushort) PACKET_COMMAND.IZ_MEMORIALDUNGEON_INFO2;
        }

        public IZ_MEMORIALDUNGEON_INFO2(byte[] packet)
            : base(packet)
        {
            using (var ms = new MemoryStream(packet))
            {
                using (var br = new BinaryReader(ms))
                {
                    Command = br.ReadUInt16();
                    Length = br.ReadUInt16();
                    AID = br.ReadInt32();
                    GID = br.ReadInt32();
                    DestroyDate = br.ReadInt32();
                    EnterTimeOutDate = br.ReadInt32();
                    DungeonName = br.ReadCString(Length - 20);

                    if (ms.Position != ms.Length)
                    {
                        throw new NotImplementedException();
                    }
                }
            }
        }

        public override void WriteTo(BinaryWriter bw)
        {
            bw.Write(Command);
            bw.Write(Length);
            bw.Write(AID);
            bw.Write(GID);
            bw.Write(DestroyDate);
            bw.Write(EnterTimeOutDate);
            bw.WriteCString(DungeonName);
        }
    }
}
