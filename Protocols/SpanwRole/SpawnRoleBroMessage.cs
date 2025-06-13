// Request(Req): 客户端 发-> 服务端
using System;
using UnityEngine;

namespace MyTelepathy {

    public struct SpawnRoleBroMessage {
        public RoleType roleType;
        public string roleName;
        public Vector2 pos;
        public int idSig;

        public void Init(RoleType roleType,int idSig, string roleName, Vector2 pos) {
            this.roleType = roleType;
            this.idSig = idSig;
            this.roleName = roleName;
            this.pos = pos;
        }

    }

}