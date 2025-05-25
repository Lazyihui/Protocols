using System;
using UnityEngine;
namespace MyTelepathy {
    public struct StuffSpawnReqMessage {
        public IDSignature idSig;
        public Vector3 pos;

        public void Init(IDSignature idSig, Vector3 pos) {
            this.idSig = idSig;
            this.pos = pos;
        }
        
    }
}

