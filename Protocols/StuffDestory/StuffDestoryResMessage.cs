using System;
using UnityEngine;

namespace MyTelepathy{
    
    public struct StuffDestoryResMessage {
        public int iDSignature;
        public void Init(int iDSignature) {
            this.iDSignature = iDSignature;
        }
        
    }
}