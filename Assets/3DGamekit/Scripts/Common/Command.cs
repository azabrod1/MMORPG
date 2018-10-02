﻿/*
 * message code define
 * if you are changing this file, mind to rebuild both Frontend and Backend later
 */

namespace Common
{
    public enum Command
    {
        NONE,
        SBEGIN = 0,
        S_PLAYER_ENTER,
        S_ITEM_SPAWN,
        S_ENTITY_SPAWN,
        S_PLAYER_ACTION,
        S_ENTITY_DESTORY,
        S_ACTION_MOVE,
        S_ACTION_JUMP,
        S_ACTION_ATTACK,
        S_EQUIP_WEAPON,
        S_BE_HITTED,
        S_TAKE_ITEM,
        S_EXIT,

        SEND,

        CBEGIN,
        C_LOGIN,
        C_ENTER_SCENE_DONE,
        C_PLAYER_ATTACK,
        C_PLAYER_JUMP,
        C_PLAYER_MOVE,
        C_PLAYER_TAKE,
        CEND,

        DEBUGGING, // THE FOLLOWING MESSEGES ARE FOR DEBUGGING
        C_PATH_FINDING,
        S_PATH_FINDING,

        CMD_END, // DO NOT GREATER THAN UINT_MAX !!!
    }
}
