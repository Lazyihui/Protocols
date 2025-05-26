using System;
using MyTelepathy;
using UnityEngine;

namespace MyTelepathy {

    public struct StuffMoveReqMessage {
        public IDSignature iDSignature;
        public Vector3 pos;

        public void Init(IDSignature iDSignature, Vector3 pos) {
            this.iDSignature = iDSignature;
            this.pos = pos;
        }
    }

}