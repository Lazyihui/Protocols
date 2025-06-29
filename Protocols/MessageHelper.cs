using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using MyTelepathy;

namespace MyTelepathy {
    public static class MessageHelper {

        static Dictionary<Type, int> typeIDMap = new Dictionary<Type, int>() {
            { typeof(SpawnRoleReqMessage), MessageConst.SpawnRole_Req },
            { typeof(SpawnRoleResMessage), MessageConst.SpawnRole_Res },
            { typeof(SpawnRoleBroMessage), MessageConst.SpawnRole_Bro },

            {typeof(MoveReqMessage), MessageConst.Move_Req },
            {typeof(MoveResMessage), MessageConst.Move_res },
            {typeof(MoveBroMessage),MessageConst.Move_Bro},

            {typeof(SpawnBulletReqMessage), MessageConst.BulletSpawn_Req},
            {typeof(SpawnBulletResMessage), MessageConst.BulletSpawn_Res},
            {typeof(SpawnBulletBroMessage), MessageConst.BulletSpawn_Bro},

            {typeof(BulletMoveReqMessage), MessageConst.BulletMove_Req},
            {typeof(BulletMoveResMessage), MessageConst.BulletMove_Res},
            {typeof(BulletMoveBroMessage), MessageConst.BulletMove_Bro},

            {typeof(BulletDestoryReqMessage), MessageConst.BulletDestory_Req},
            {typeof(BulletDestoryResMessage), MessageConst.BulletDestory_Res},
            {typeof(BulletDestoryBroMessage), MessageConst.BulletDestory_Bro},

            {typeof(StuffSpawnReqMessage), MessageConst.StuffSpawn_Req},
            {typeof(StuffSpawnResMessage), MessageConst.StuffSpawn_Res},
            {typeof(StuffSpawnBroMessage), MessageConst.StuffSpawn_Bro},

            {typeof(StuffDestoryReqMessage), MessageConst.StuffDestory_Req},
            {typeof(StuffDestoryResMessage), MessageConst.StuffDestory_Res},
            {typeof(StuffDestoryBroMessage), MessageConst.StuffDestory_Bro},

            {typeof(StuffMoveReqMessage), MessageConst.StuffMove_Req},
            {typeof(StuffMoveResMessage), MessageConst.StuffMove_Res},
            {typeof(StuffMoveBroMessage), MessageConst.StuffMove_Bro},

            {typeof(RoleDestoryReqMessage), MessageConst.RoleDestory_Req},
            {typeof(RoleDestoryResMessage), MessageConst.RoleDestory_Res},
            {typeof(RoleDestoryBroMessage), MessageConst.RoleDestory_Bro},
        };


        public static int GetTypeID<T>() {
            Type type = typeof(T);
            if (typeIDMap.ContainsKey(type)) {
                return typeIDMap[type];
            } else {
                Debug.LogError("Type not found in typeIDMap: " + type);
                return -1;
            }
        }
        
        // TODO:要改成用对象池
        public static byte[] ToData<T>(T msg) {
            string str = JsonUtility.ToJson(msg);
            int typeID = GetTypeID<T>();

            byte[] msg_header = BitConverter.GetBytes(typeID);
            byte[] msg_data = Encoding.UTF8.GetBytes(str);
            byte[] msg_length = BitConverter.GetBytes(msg_data.Length);

            byte[] data = new byte[msg_header.Length + msg_length.Length + msg_data.Length];// 头部 + 长度 + 数据 4+4+N

            Buffer.BlockCopy(msg_header, 0, data, 0, msg_header.Length);
            Buffer.BlockCopy(msg_length, 0, data, msg_header.Length, msg_length.Length);
            Buffer.BlockCopy(msg_data, 0, data, msg_header.Length + msg_length.Length, msg_data.Length);

            return data;
        }

        public static int ReadHeader(byte[] data) {
            if (data.Length < 4) {
                return -1;
            } else {
                int typeID = BitConverter.ToInt32(data, 0);
                return typeID;
            }
        }

        public static T ReadDate<T>(byte[] data) where T : struct {
            if (data.Length < 4) {
                return default;
            } else {
                int typeID = ReadHeader(data);
                if (typeID != GetTypeID<T>()) {

                    Debug.LogError("TypeID not match: " + typeID + " " + GetTypeID<T>());
                    return default;
                } else {
                    int Length = BitConverter.ToInt32(data, 4);
                    string str = Encoding.UTF8.GetString(data, 8, Length);
                    T msg = JsonUtility.FromJson<T>(str);
                    return msg;
                }
            }

        }
    }
}