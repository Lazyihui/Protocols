using System;
using MyTelepathy;
using UnityEngine;

namespace MyTelepathy {

    public struct StuffMoveReqMessage {
        public int idSig;
        public Vector3 pos;

        public void Init(int iDSignature, Vector3 pos) {
            this.idSig = iDSignature;
            this.pos = pos;
        }
    }

}