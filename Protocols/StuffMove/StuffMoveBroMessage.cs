using System;
using MyTelepathy;
using UnityEngine;

namespace MyTelepathy {

    public struct StuffMoveBroMessage {
        public int iDSignature;
        public Vector3 pos;

        public void Init(int iDSignature, Vector3 pos) {
            this.iDSignature = iDSignature;
            this.pos = pos;
        }
    }

}