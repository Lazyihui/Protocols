using System;
using UnityEngine;

namespace MyTelepathy {
    public struct MoveReqMessage {
        public string roleName;
        public Vector3 targetPos;
        public long timestamp;  // 用于客户端预测

        public void Init(string roleName, Vector3 targetPos) {
            this.roleName = roleName;
            this.targetPos = targetPos;
            this.timestamp = DateTime.UtcNow.Ticks;
        }
    }
}