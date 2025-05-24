using System;
using UnityEngine;

namespace MyTelepathy {

    public struct SpawnBulletBroMessage {
        public Transform rootPos;
        public Vector3 dir;// 方向 应该只要在Server里面用 所以这个应该可以删掉
        public IDSignature idSig;

    }

}