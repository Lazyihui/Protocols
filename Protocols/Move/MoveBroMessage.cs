using System;
using UnityEngine;

namespace MyTelepathy {
    public struct MoveBroMessage {
        public string roleName;
        public Vector3 targetPos;
        public long timestamp;  // 用于客户端预测
    }
}