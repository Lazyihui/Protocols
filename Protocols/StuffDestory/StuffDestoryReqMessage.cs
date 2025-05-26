using System;
using UnityEngine;

namespace MyTelepathy{
    
    public struct StuffDestoryReqMessage {
        public IDSignature idSig;
        
        public void Init(IDSignature iDSignature) {
            this.idSig = iDSignature;
        }
    }
}