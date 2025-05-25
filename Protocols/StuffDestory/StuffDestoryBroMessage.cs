using System;
using UnityEngine;

namespace MyTelepathy {

    public struct StuffDestoryBroMessage {
        public IDSignature iDSignature;
        public void Init(IDSignature iDSignature) {
            this.iDSignature = iDSignature;
        }

    }
}