using System;
using UnityEngine;

namespace MyTelepathy {

    public struct SpawnBulletBroMessage {
        public Transform rootPos;
        public Vector3 dir;// 方向 应该只要在Server里面用 所以这个应该可以删掉
        public int idSig;
        public void Init(Transform rootPos, Vector3 dir, int idSignature) {
            this.rootPos = rootPos;
            this.dir = dir;
            this.idSig = idSignature;
        }

    }

}