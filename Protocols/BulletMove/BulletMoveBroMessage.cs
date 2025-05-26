using System;
using UnityEngine;

namespace MyTelepathy {

    public struct BulletMoveBroMessage {
        public int idSig;
        public Vector3 position;
        public void Init(int iDSignature, Vector3 pos) {
            this.idSig = iDSignature;
            this.position = pos;
        }
    }
}
