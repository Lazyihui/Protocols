using System;
using UnityEngine;

namespace MyTelepathy {

    public struct StuffDestoryBroMessage {
        public int idSig;
        public void Init(int iDSignature) {
            this.idSig = iDSignature;
        }

    }
}