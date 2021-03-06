﻿using System;

namespace Aegis.CrossCutting.Network
{
    [Serializable]
    public enum PACKET_COMMAND : ushort
    {
        CA_LOGIN = 0x64,
        CH_ENTER = 0x65,
        CH_SELECT_CHAR = 0x66,
        CH_MAKE_CHAR = 0x67,
        CH_DELETE_CHAR = 0x68,

        SERVER_ENTRY = 0x2904,
        HA_LOGON = 0x2905,
        AH_LOGON_EXIST = 0x2906,
        AH_LOGON_NOTEXIST = 0x2907,
        ZH_LOGON = 0x2908,
        HZ_LOGON_EXIST = 0x2909,
        HZ_LOGON_NOTEXIST = 0x290a,
        ZH_CHAR_EXIT = 0x290b,
        HA_CHAR_EXIT = 0x290c,
        AH_DISCONNECT = 0x290d,
        HZ_DISCONNECT = 0x290e,
        HZ_ACK_RESTART = 0x290f,
        ZH_RESTART = 0x2910,
        CONNECTION_CLOSED = 0x2911,
        SAVE_USING_TIME = 0x2912,
        ZH_SAVECHARINFO = 0x2913,
        ZH_MAPMOVE = 0x2914,
        HZ_ACK_MAPMOVE = 0x2915,
        ZI_LOGON = 0x2916,
        ZI_EXIT = 0x2917,
        ZI_WHISPER = 0x2918,
        IZ_WHISPER = 0x2919,
        IZ_ACK_WHISPER = 0x291a,
        ZI_ACK_WHISPER = 0x291b,
        ZI_REQ_USER_COUNT = 0x291c,
        IZ_USER_COUNT = 0x291d,
        ZI_BROADCAST = 0x291e,
        IZ_BROADCAST = 0x291f,
        ZI_MAKE_GROUP = 0x2920,
        IZ_ACK_MAKE_GROUP = 0x2921,
        IZ_GROUP_LIST = 0x2922,
        ZI_REQ_JOIN_GROUP = 0x2923,
        IZ_ACK_REQ_JOIN_GROUP = 0x2924,
        IZ_REQ_JOIN_GROUP = 0x2925,
        ZI_JOIN_GROUP = 0x2926,
        ZI_REQ_LEAVE_GROUP = 0x2927,
        ZI_REQ_EXPEL_GROUP_MEMBER = 0x2928,
        IZ_ADD_MEMBER_TO_GROUP = 0x2929,
        IZ_DELETE_MEMBER_FROM_GROUP = 0x292a,
        ZI_MAPMOVE = 0x292b,
        ZI_GRID_UPDATE = 0x292c,
        ZI_CHAT_PARTY = 0x292d,
        IZ_CHAT_PARTY = 0x292e,
        IZ_DISCONNECT_ALL = 0x292f,
        ZI_DISCONNECT_ALL = 0x2930,
        ZI_CHANGE_EXPOPTION = 0x2931,
        HA_PCINFOUPDATE = 0x2932,
        IZ_REQ_SERVERSTATE = 0x2933,
        IZ_SHOTDOWN = 0x2934,
        ZI_SERVERSTATE = 0x2935,
        ZI_REQ_MYGUILD_BASIC_INFO = 0x2936,
        ZI_REQ_MAKE_GUILD = 0x2937,
        IZ_MYGUILD_BASICINFO = 0x2938,
        ZI_REQ_GUILD_MENUINTERFACE = 0x2939,
        IZ_ACK_MYGUILD_MEMBER_INFO = 0x293a,
        IZ_ACK_MYGUILD_POSITION = 0x293b,
        IZ_ACK_MYGUILD_BANISH = 0x293c,
        IZ_ACK_MYGUILD_LIST = 0x293d,
        ZI_REGISTER_GUILD_EMBLEM_IMG = 0x293e,
        IZ_GET_GUILD_EMBLEM_IMG = 0x293f,
        ZI_MEMBERMGR_INFO = 0x2940,
        IZ_MEMBERMGR_INFO = 0x2941,
        ZI_REQ_CHANGE_MEMBERPOS = 0x2942,
        IZ_ACK_CHANGE_MEMBERPOS = 0x2943,
        ZI_REQ_OPEN_MEMBER_INFO = 0x2944,
        IZ_ACK_OPEN_MEMBER_INFO = 0x2945,
        ZI_REQ_LEAVE_GUILD = 0x2946,
        IZ_ACK_LEAVE_GUILD = 0x2947,
        ZI_REQ_BAN_GUILD = 0x2948,
        IZ_ACK_BAN_GUILD = 0x2949,
        ZI_REQ_DISORGANIZE_GUILD = 0x294a,
        IZ_REQ_DISORGANIZE_GUILD_RESULT = 0x294b,
        ZI_REQ_GUILD_POSITION_INFO = 0x294c,
        IZ_ACK_GUILD_POSITION_INFO = 0x294d,
        IZ_SKILL_INFO = 0x294e,
        IZ_BAN_LIST = 0x294f,
        IZ_OTHER_GUILD_LIST = 0x2950,
        ZI_REQ_JOIN_GUILD = 0x2951,
        IZ_REQ_JOIN_GUILD = 0x2952,
        ZI_JOIN_GUILD = 0x2953,
        IZ_ACK_REQ_JOIN_GUILD = 0x2954,
        IZ_GUILD_LIST_TOD = 0x2955,
        IZ_GUILDINFO_TOD = 0x2956,
        IZ_GUILD_MEMBERINFO_TOD = 0x2957,
        IZ_GUILD_ALLYINFO_TOD = 0x2958,
        IZ_GUILD_BANISHINFO_TOD = 0x2959,
        IZ_GUILD_MPOSITION_TOD = 0x295a,
        IZ_GUILD_NOTICE_TOD = 0x295b,
        IZ_RESULT_MAKE_GUILD = 0x295c,
        IZ_UPDATE_CHARGDID = 0x295d,
        IZ_UPDATE_CHARSTAT = 0x295e,
        ZI_GUILD_NOTICE = 0x295f,
        IZ_GUILD_NOTICE = 0x2960,
        ZI_ALLY_GUILD = 0x2961,
        IZ_ACK_REQ_ALLY_GUILD = 0x2962,
        IZ_ADD_ALLY_GUILD = 0x2963,
        ZI_REQ_HOSTILE_GUILD = 0x2964,
        IZ_ACK_REQ_HOSTILE_GUILD = 0x2965,
        IZ_ADD_HOSTILE_GUILD = 0x2966,
        IZ_GUILD_MEMBER_ADD = 0x2967,
        ZI_REQ_DELETE_RELATED_GUILD = 0x2968,
        IZ_DELETE_RELATED_GUILD = 0x2969,
        ZI_ACTOR_INIT = 0x296a,
        ZI_GUILD_CHAT = 0x296b,
        IZ_GUILD_CHAT = 0x296c,
        ZI_ADD_EXP = 0x296d,
        IZ_ADD_EXP = 0x296e,
        IZ_GUILD_LEVEL_UP = 0x296f,
        IZ_GUILD_MEMBERINFO_FRAG = 0x2970,
        IZ_GET_GUILD_EMBLEM_IMG_FRAG = 0x2971,
        ZI_REGISTER_GUILD_EMBLEM_IMG_FRAG = 0x2972,
        AH_DISCONNECT_RIGHTNOW = 0x2973,
        HZ_DISCONNECT_RIGHTNOW = 0x2974,
        ZI_CHAR_LEVEL_UP = 0x2975,
        ZI_GUILD_ZENY = 0x2976,
        IZ_GUILD_ZENY = 0x2977,
        ZI_GUILD_ZENY_UPDATE_ALL = 0x2978,
        IZ_GUILD_ZENY_UPDATE_ALL = 0x2979,
        ZI_GUILD_PRELOAD = 0x297a,
        ZI_GUILD_CHANGEOWNER_AGIT = 0x297b,
        HA_REQ_PACKETINFO = 0x297c,
        AH_ACK_PACKETINFO = 0x297d,
        ZH_REQ_REMAINTIME = 0x297e,
        HA_REQ_REMAINTIME = 0x297f,
        AH_RES_REMAINTIME = 0x2980,
        HZ_RES_REMAINTIME = 0x2981,
        AH_INFO_REMAINTIME = 0x2982,
        HZ_INFO_REMAINTIME = 0x2983,
        IZ_GUILD_NOTIFYSKILLDATA = 0x2984,
        ZI_GDSKILL_UPDATE = 0x2985,
        ZE_REQ_CERTIFICATE = 0x2986,
        EZ_PERMIT_CERTIFICATE = 0x2987,
        ZI_MOVE = 0x2988,
        IZ_MOVE = 0x2989,
        ZI_GUILD_CHANGEMAXUSER = 0x298a,
        IZ_GUILD_CHANGEMAXUSER = 0x298b,
        IZ_FREE_GUILD = 0x298c,
        IZ_GUILD_CHANGEOWNER_AGIT = 0x298d,
        ZI_MAKE_GROUP2 = 0x298e,
        IZ_ADD_MEMBER_TO_GROUP2 = 0x298f,
        ZI_MOVE_GID = 0x2990,
        IZ_GUILD_MAP_CHANGE = 0x2991,
        ZI_VERSION = 0x2992,
        ZI_CHANGE_EXPOPTION2 = 0x2993,
        HA_LOGON_SESSION = 0x2994,
        AH_LOGON_EXIST_SESSION = 0x2995,
        AH_LOGON_NOTEXIST_SESSION = 0x2996,
        ZI_DIVORCE = 0x2997,
        IZ_DIVORCE = 0x2998,
        IZ_FRIENDS_LIST = 0x2999,
        IZ_FRIENDS_STATE = 0x299a,
        ZI_ACK_REQ_ADD_FRIENDS = 0x299b,
        IZ_ADD_FRIENDS = 0x299c,
        ZI_DELETE_FRIENDS = 0x299d,
        IZ_DELETE_FRIENDS = 0x299e,
        ZI_MOVE_SERVER = 0x299f,
        SVR_PING = 0x29a0,
        IZ_NOTIFY_MAKERRANK = 0x29a1,
        ZI_UPDATE_MAKERRANK = 0x29a2,
        ZI_MAIL_GET_LIST = 0x29a3,
        IZ_MAIL_REQ_GET_LIST = 0x29a4,
        ZI_MAIL_OPEN = 0x29a5,
        IZ_MAIL_REQ_OPEN = 0x29a6,
        ZI_MAIL_DELETE = 0x29a7,
        IZ_ACK_MAIL_DELETE = 0x29a8,
        ZI_MAIL_GET_ITEM = 0x29a9,
        IZ_MAIL_REQ_GET_ITEM = 0x29aa,
        ZI_MAIL_SEND = 0x29ab,
        IZ_MAIL_REQ_SEND = 0x29ac,
        IZ_MAIL_RECEIVE = 0x29ad,
        ZI_EPISODE_VERSION = 0x29ae,
        IZ_CHK_PROCESSTIME = 0x29af,
        ZI_ACK_CHK_PROCESSTIME = 0x29b0,
        IZ_DISCONNECT_CHARACTER = 0x29b1,
        IZ_ACK_LOGON = 0x29b2,
        ZI_REQ_MAIL_RETURN = 0x29b3,
        IZ_ACK_MAIL_RETURN = 0x29b4,
        HZ_NOTIFY_PCBANG = 0x29b5,
        AH_LOGON_EXIST_PCBANG = 0x29b6,
        HA_CHAR_SVR_INFO = 0x29b7,
        HA_REQ_PLAYING_LIMITINFO = 0x29b8,
        AH_ACK_PLAYING_LIMITINFO = 0x29b9,
        AH_LOGON_EXIST_PCBANG_HAN = 0x29ba,
        HZ_PING = 0x29bb,
        ZI_MEMORIALDUNGEON_SUBSCRIPTION = 0x29bc,
        NOT_USED_IZ_MEMORIALDUNGEON_CREATE_RESULT = 0x29bd,
        IZ_INSTANTMAP_CREATE_REQ = 0x29be,
        ZI_INSTANTMAP_CREATE_RES = 0x29bf,
        HZ_NOTIFY_PCBANG_PLAYING_TIME = 0x29c0,
        ZI_SERVERSTATE_HAN_GAME = 0x29c1,
        AH_NOTIFY_PCBANG_PLAYING_TIME = 0x29c2,
        IZ_INSTANTMAP_PLAYER_ENTER = 0x29c3,
        ZI_INSTANTMAP_ERROR = 0x29c4,
        IZ_INSTNATMAP_DESTROY = 0x29c5,
        ZI_PING = 0x29c6,
        ZI_INSTANTMAP_ALLOW = 0x29c7,
        XX_CONNECT = 0x29c8,
        XX_DISCONNECT = 0x29c9,
        IZ_MEMORIALDUNGEON_MSG = 0x29ca,
        NOT_USED_ZI_MEMORIALDUNGEON_NOTIFY_CONFIRM = 0x29cb,
        ZI_PARTY_JOIN_REQ = 0x29cc,
        IZ_PARTY_JOIN_REQ_ACK = 0x29cd,
        IZ_PARTY_JOIN_REQ = 0x29ce,
        ZI_PARTY_JOIN_REQ_ACK = 0x29cf,
        AH_LOGON_ACK_EXTEND_BILLING_INFO = 0x29d0,
        IZ_MEMORIALDUNGEON_SUBSCRIPTION_INFO = 0x29d1,
        IZ_MEMORIALDUNGEON_SUBSCRIPTION_NOTIFY = 0x29d2,
        IZ_MEMORIALDUNGEON_INFO = 0x29d3,
        IZ_MEMORIALDUNGEON_NOTIFY = 0x29d4,
        ZI_MEMORIALDUNGEON_COMMAND = 0x29d5,
        IZ_MEMORIALDUNGEON_SYNC = 0x29d6,
        ZI_MEMORIALDUNGEON_VISA = 0x29d7,
        IZ_MEMORIALDUNGEON_VISA = 0x29d8,
        IZ_MEMORIALDUNGEON_COMMAND = 0x29d9,
        ZH_PLAYER_ALIVE = 0x29da,
        IZ_LEAVE_GROUP = 0x29db,
        ZI_MEMORIALDUNGEON_OPENSTATE = 0x29dc,
        IZ_MEMORIALDUNGEON_OPENSTATE = 0x29dd,
        ZI_ENTRANCESTATION_REGIST = 0x29de,
        IZ_WAITINGROOM_SUBSCRIPTION_RESULT = 0x29df,
        ZI_WAITINGROOM_MY_SUBSCRIPTION_INFO = 0x29e0,
        IZ_WAITINGROOM_MY_SUBSCRIPTION_INFO = 0x29e1,
        IZ_WAITINGROOM_PARTYPLAY_JOIN_NOTI = 0x29e2,
        ZI_WAITINGROOM_PARTYPLAY_JOIN_RESULT = 0x29e3,
        IZ_WAITINGROOM_START = 0x29e4,
        ZI_WAITINGROOM_PLAYER_STATE = 0x29e5,
        AH_DISPATCH_PREMIUM_INFO = 0x29e6,
        HZ_CHAR_NAME_CHANGED = 0x29e7,
        ZI_GROUPINFO_CHANGE_V2 = 0x29e8,
        IZ_REQ_GROUPINFO_CHANGE_V2 = 0x29e9,
        ZI_CHANGE_GROUP_MASTER = 0x29ea,
        ZH_CASTLE_MAP_MOVE = 0x29eb,
        AH_BILLING_ACK = 0x29ec,
        HA_LOGON2 = 0x29ed,
        ZI_SEEK_PARTY = 0x29ee,
        IZ_SEEK_PARTY = 0x29ef,
        ZI_SEEK_PARTY_MEMBER = 0x29f0,
        IZ_SEEK_PARTY_MEMBER = 0x29f1,
        ZI_GET_MY_BATTLEFILED_INFO = 0x29f2,
        IZ_BATTLEFILED_SETTING = 0x29f3,
        IZ_BATTLEFIELD_NOTI = 0x29f4,
        ZI_FINAL_BATTLE_PLAY = 0x29f5,
        DESTROY_PACKET_1 = 0x29f6,
        DESTROY_PACKET_2 = 0x29f7,
        DESTROY_PACKET_3 = 0x29f8,
        DESTROY_PACKET_4 = 0x29f9,
        DESTROY_PACKET_5 = 0x29fa,
        DESTROY_PACKET_6 = 0x29fb,
        DESTROY_PACKET_7 = 0x29fc,
        DESTROY_PACKET_8 = 0x29fd,
        DESTROY_PACKET_9 = 0x29fe,
        DESTROY_PACKET_10 = 0x29ff,
        ZI_INTERSERVER_ORDER = 0x2a00,
        AH_UPDATE_PCBANG_CNT = 0x2a01,
        HA_CHECKBOT_REQ = 0x2a02,
        AH_CHECKBOT_ACK = 0x2a03,
        HA_CHECKBOT_UPDATE = 0x2a04,
        ZI_BATTLE_FIELD_LIST = 0x2a05,
        IZ_BATTLE_FIELD_LIST = 0x2a06,
        ZI_JOIN_BATTLE_FIELD = 0x2a07,
        IZ_JOIN_BATTLE_FIELD = 0x2a08,
        ZI_CANCEL_BATTLE_FIELD = 0x2a09,
        IZ_CANCEL_BATTLE_FIELD = 0x2a0a,
        ZI_REQ_BATTLE_STATE_MONITOR = 0x2a0b,
        IZ_ACK_BATTLE_STATE_MONITOR = 0x2a0c,
        IZ_BATTLE_NOTI_START_STEP = 0x2a0d,
        IZ_BATTLE_JOIN_NOTI_DEFER = 0x2a0e,
        IZ_BATTLE_JOIN_DISABLE_STATE = 0x2a0f,
        IZ_BATTLE_USER_STATE_CHECK = 0x2a10,
        ZI_BATTLE_USER_STATE_CHECK = 0x2a11,
        IZ_MOVE_FROM_BATTLEFIELD = 0x2a12,
        ZI_BEFORE_BATTLE_MY_POSITION = 0x2a13,
        IZ_BEFORE_BATTLE_MY_POSITION = 0x2a14,
        IZ_CHANGE_GROUP_MASTER = 0x2a15,
        ZI_BROADCASTING_SPECIAL_ITEM_OBTAIN = 0x2a16,
        IZ_BROADCASTING_SPECIAL_ITEM_OBTAIN = 0x2a17,
        IZ_DEFINE_CHECK = 0x2a18,
        ZI_SERVERSTATE_CHANNELING = 0x2a19,
        ZI_PARTY_BOOKING_NOTIFY_INSERT = 0x2a1a,
        IZ_PARTY_BOOKING_NOTIFY_INSERT = 0x2a1b,
        ZI_PARTY_BOOKING_NOTIFY_DELETE = 0x2a1c,
        IZ_PARTY_BOOKING_NOTIFY_DELETE = 0x2a1d,
        ZI_PARTY_BOOKING_NOTIFY_UPDATE = 0x2a1e,
        IZ_PARTY_BOOKING_NOTIFY_UPDATE = 0x2a1f,
        ZI_REQ_MAKE_GUILD_SSO = 0x2a20,
        ZI_REQ_BAN_GUILD_SSO = 0x2a21,
        IZ_ACK_BAN_GUILD_SSO = 0x2a22,
        ZI_JOIN_GUILD_SSO = 0x2a23,
        HZ_ZSVR_INFO = 0x2a24,
        ZH_ZSVR_INFO = 0x2a25,
        IH_PING = 0x2a26,
        HI_PING = 0x2a27,
        ZI_WHISPER_2 = 0x2a28,
        IZ_WHISPER_2 = 0x2a29,
        ZI_MOVE_2 = 0x2a2a,
        XX_REQ_PACKAGEITEMLIST = 0x2a2b,
        IZ_ACK_PACKAGEITEMLIST = 0x2a2c,
        ZI_REQ_UNPACK_PACKAGE_ITEM = 0x2a2d,
        IZ_ACK_UNPACK_PACKAGE_ITEM = 0x2a2e,
        ZI_ROLLBACK_PACKAGE_ITEM = 0x2a2f,
        ZI_GPK_DYNCODE_RELOAD = 0x2a30,
        IZ_GPK_DYNCODE_RELOAD = 0x2a31,
        HZ_USER_COUNT_REQ = 0x2a32,
        ZH_USER_COUNT_ACK = 0x2a33,
        ZH_CHAR_EXIT2 = 0x2a34,
        ZH_RESTART2 = 0x2a35,
        HA_REQ_AID_CHECK = 0x2a36,
        AH_ACK_AID_CHECK = 0x2a37,
        IZ_IRMAIL_NOTIFY = 0x2a38,
        HZ_PERSONAL_INFORMATION = 0x2a39,
        AH_LOGON_UNION_SECONDPW = 0x2a3a,
        ZI_AUTH_REQ = 0x2a3b,
        IZ_AUTH_ACK = 0x2a3c,
        ZH_AUTH_REQ = 0x2a3d,
        HZ_AUTH_ACK = 0x2a3e,
        IZ_REQ_EDIT_EXP = 0x2a3f,
        HZ_PERSONAL_INFORMATION_2ND = 0x2a40,
        HA_IPBONUS_LIMIT = 0x2a41,
        ZI_INFO_ENTRY_QUEUE_APPLY = 0x2a42,
        IZ_INFO_ENTRY_QUEUE_APPLY = 0x2a43,
        ZI_REQ_ENTRY_QUEUE_APPLY = 0x2a44,
        IZ_NOTIFY_ENTRY_QUEUE_APPLY = 0x2a45,
        ZI_RESULT_ENTRY_QUEUE_APPLY = 0x2a46,
        IZ_RESULT_ENTRY_QUEUE_APPLY = 0x2a47,
        ZI_INFO_ENTRY_QUEUE_CANCEL = 0x2a48,
        IZ_INFO_ENTRY_QUEUE_CANCEL = 0x2a49,
        ZI_REQ_ENTRY_QUEUE_CANCEL = 0x2a4a,
        IZ_NOTIFY_ENTRY_QUEUE_CANCEL = 0x2a4b,
        ZI_RESULT_ENTRY_QUEUE_CANCEL = 0x2a4c,
        IZ_RESULT_ENTRY_QUEUE_CANCEL = 0x2a4d,
        ZI_ENTRY_QUEUE_ADMISSION = 0x2a4e,
        IZ_ENTRY_QUEUE_ADMISSION = 0x2a4f,
        ZI_ENTRY_QUEUE_ADMISSION_ACCEPT = 0x2a50,
        IZ_NOTIFY_ENTRY_QUEUE_ADMISSION_ACCEPT = 0x2a51,
        ZI_RESULT_ENTRY_QUEUE_ADMISSION_ACCEPT = 0x2a52,
        IZ_RESULT_ENTRY_QUEUE_ADMISSION_ACCEPT = 0x2a53,
        ZI_ENTRY_QUEUE_ADMISSION_REFUSE = 0x2a54,
        IZ_NOTIFY_ENTRY_QUEUE_ADMISSION_REFUSE = 0x2a55,
        ZI_RESULT_ENTRY_QUEUE_ADMISSION_REFUSE = 0x2a56,
        IZ_RESULT_ENTRY_QUEUE_ADMISSION_REFUSE = 0x2a57,
        ZI_LOBBY_ADMISSION = 0x2a58,
        IZ_LOBBY_ADMISSION = 0x2a59,
        ZI_LOBBY_ADMISSION_ACCEPT = 0x2a5a,
        IZ_NOTIFY_LOBBY_ADMISSION_ACCEPT = 0x2a5b,
        ZI_RESULT_LOBBY_ADMISSION_ACCEPT = 0x2a5c,
        IZ_RESULT_LOBBY_ADMISSION_ACCEPT = 0x2a5d,
        ZI_LOBBY_ADMISSION_REFUSE = 0x2a5e,
        IZ_NOTIFY_LOBBY_ADMISSION_REFUSE = 0x2a5f,
        ZI_RESULT_LOBBY_ADMISSION_REFUSE = 0x2a60,
        IZ_RESULT_LOBBY_ADMISSION_REFUSE = 0x2a61,
        IZ_ENTRY_QUEUE_LOGOUT = 0x2a62,
        ZI_ENTRY_QUEUE_MOVE_ROOM = 0x2a63,
        IZ_ENTRY_QUEUE_MOVE_ROOM = 0x2a64,
        ZI_LOBBY_MOVE_ROOM = 0x2a65,
        IZ_LOBBY_MOVE_ROOM = 0x2a66,
        ZI_ENTRY_QUEUE_NAME = 0x2a67,
        ZI_PARTY_RECRUIT_NOTIFY_INSERT = 0x2a68,
        IZ_PARTY_RECRUIT_NOTIFY_INSERT = 0x2a69,
        ZI_PARTY_RECRUIT_NOTIFY_DELETE = 0x2a6a,
        IZ_PARTY_RECRUIT_NOTIFY_DELETE = 0x2a6b,
        ZI_PARTY_RECRUIT_NOTIFY_UPDATE = 0x2a6c,
        IZ_PARTY_RECRUIT_NOTIFY_UPDATE = 0x2a6d,
        ZI_PARTY_RECRUIT_VOLUNTEER_INFO = 0x2a6e,
        IZ_PARTY_RECRUIT_VOLUNTEER_INFO = 0x2a6f,
        ZI_PARTY_RECRUIT_REQ_RECALL = 0x2a70,
        IZ_PARTY_RECRUIT_REQ_RECALL = 0x2a71,
        ZI_PARTY_RECRUIT_FAILED_RECALL = 0x2a72,
        IZ_PARTY_RECRUIT_FAILED_RECALL = 0x2a73,
        ZI_PARTY_RECRUIT_REFUSE_VOLUNTEER = 0x2a74,
        IZ_PARTY_RECRUIT_REFUSE_VOLUNTEER = 0x2a75,
        AH_JPN_LOGON_ACK = 0x2a76,
        HZ_JPN_PREMIUM_CAMPAIGN = 0x2a77,
        ZI_ENTRY_QUEUE_DELETE_GID = 0x2a78,
        ZI_MEMORIALDUNGEON_SUBSCRIPTION2 = 0x2a79,
        IZ_MEMORIALDUNGEON_SYNC2 = 0x2a7a,
        IZ_MEMORIALDUNGEON_MSG2 = 0x2a7b,
        IZ_MEMORIALDUNGEON_SUBSCRIPTION_INFO2 = 0x2a7c,
        IZ_MEMORIALDUNGEON_INFO2 = 0x2a7d,
        ZI_PARTY_RECRUIT_CANCEL_VOLUNTEER = 0x2a7e,
        IZ_PARTY_RECRUIT_CANCEL_VOLUNTEER = 0x2a7e,
        ZH_PING = 0x2a7f,
        ZI_ENTRY_QUEUE_RANKING = 0x2a80,
        IZ_ENTRY_QUEUE_RANKING = 0x2a81,
        ZI_NOTIFY_ENTRY_QUEUE_RANKING = 0x2a82,
        IZ_NOTIFY_ENTRY_QUEUE_RANKING = 0x2a83,
        ZH_LOGON2RD = 0x2a84,
        ZH_START2RD = 0x2a85,
        ZI_JOB_CHANGE = 0x2a86,
        HZ_PREMIUM_CAMPAIGN_INFO = 0x2a87,
        ZI_LOBBY_ADMISSION_V2 = 0x2a88,
        IZ_LOBBY_ADMISSION_V2 = 0x2a89,
        ZI_REQ_JOIN_GUILD2 = 0x2a8a,
        IZ_REQ_JOIN_GUILD2 = 0x2a8b,
        ZI_LIST_JOIN_GUILD_INSERT_GID = 0x2a8c,
        ZI_LIST_JOIN_GUILD_CHECK_GID = 0x2a8d,
        ZI_PING_LIVE = 0x2a8e,
        IZ_PING_LIVE = 0x2a8f,
        ZI_STATEINFO = 0x2a90,
        ZH_PING_LIVE = 0x2a91,
        HZ_PING_LIVE = 0x2a92,
        HZ_PERSONAL_INFORMATION_BRZ = 0x2a93,
        ZI_OTHER_ZONE_PC_SEND_MSG = 0x2a94,
        IZ_OTHER_ZONE_PC_SEND_MSG = 0x2a95,
        ZI_REQ_PRNPC_WINNER = 0x2a96,
        IZ_ACK_PRNPC_WINNER = 0x2a97,
        ZI_SET_PRNPC_WINNER = 0x2a98,
        IZ_SET_PRNPC_WINNER = 0x2a99,
        HZ_LOGON_KOR = 0x2a9a,
        AH_LOGON_RUS = 0x2a9b,
        HZ_LOGON_TW = 0x2a9c,
        AH_DISPATCH_PREMIUM_INFO_CHN = 0x2a9d,
        HZ_FATIGUE_INFO_CHN = 0x2a9e,
        HZ_LOGON_CHN = 0x2a9f,
        HZ_PERSONAL_INFORMATION_CHN = 0x2aa0,
        AH_LOGON_ACK_CHN = 0x2aa1,
        ZI_REQ_JOIN_CLAN = 0x2aa2,
        ZI_REQ_LEAVE_CLAN = 0x2aa3,
        IZ_CLAN_CONNECTINFO = 0x2aa4,
        IZ_CLAN_CONNECTINFO_ALL = 0x2aa5,
        ZI_CLAN_CHAT = 0x2aa6,
        IZ_CLAN_CHAT = 0x2aa7,
        IZ_ACK_JOIN_CLAN = 0x2aa8,
        IZ_ACK_LEAVE_CLAN = 0x2aa9,
        ZI_REQ_USER_CLANINFO = 0x2aaa,
        IZ_ACK_USER_CLANINFO = 0x2aab,
        ZI_NPC_PROVIDE_EXPINFO = 0x2aac,
        ZI_MEMORIALDUNGEON_DESTROY = 0x2aad,
        IZ_INSTANTMAP_ADD3 = 0x2ab0,
        IZ_INSTANTMAP_REMOVE3 = 0x2ab1,
        IZ_INSTANTMAP_PLAYER_ENTER3 = 0x2ab2,
        IZ_GET_GUILD_EMBLEM_IMG2 = 0x2ab3,
        AH_LOGON_BRZ = 0x2ab4,
        AH_CONNECTED_CHN = 0x2ab5,
        IZ_SET_EFFECT_HIGH_RANKER = 0x2ab6,
        IZ_RESET_EFFECT_HIGH_RANKER = 0x2ab7,
        HZ_PERSONAL_INFORMATION_PHL = 0x2ab8,
        HZ_PERSONAL_INFORMATION_THAI = 0x2ab9,
        HZ_DISPATCH_TIMING_CHN = 0x2aba,
        HZ_PERSONAL_INFORMATION_TW = 0x2abb,
        ZI_PRIVATE_DUNGEON_RESERVE = 0x4e85,
        IZ_PRIVATE_DUNGEON_RESERVE = 0x4e86,
        IZ_PRIVATE_DUNGEON_CREATE_RESULT = 0x4e87,
        IZ_PRIVATE_DUNGEON_SYNC = 0x4e88,
        ZI_PRIVATE_DUNGEON_ENTER = 0x4e89,
        IZ_PRIVATE_DUNGEON_ENTER = 0x4e8a,

        MI_ENTER = 0x2af8,
        MI_REQ_SERVERSTATE = 0x2af9,
        MI_MSG = 0x2afa,
        MI_SHOTDOWN = 0x2afb,
        IM_CONTROLFAIL = 0x2afc,
        IM_SERVERLIST = 0x2afd,
        IM_SERVERSTATE = 0x2afe,
        IM_ACKMSG = 0x2aff,
        NOT_USE01 = 0x2b00,
        MI_GET_GUILD_INFO = 0x2b01,
        IM_REQ_GUILD_INFO = 0x2b02,
        MI_GUILD_INFO_INIT = 0x2b03,
        IM_RESULT_GUILD_INFO_INIT = 0x2b04,
        MI_ALLY_GUILD_INIT = 0x2b05,
        IM_REQ_ALLY_GUILD_INIT = 0x2b06,
        IM_SERVERSTATE_HAN_GAME = 0x2b07,
        IM_SERVERSTATE_CHANNELING = 0x2b08,
        MI_REQ_EDIT_EXP = 0x2b09,
        IM_ACK_EDIT_EXP = 0x2b0a,
    };
}