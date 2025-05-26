using System;
using UnityEngine;

namespace MyTelepathy{
    
    public struct StuffDestoryReqMessage {
        public int idSig;
        
        public void Init(int iDSignature) {
            this.idSig = iDSignature;
        }
    }
}