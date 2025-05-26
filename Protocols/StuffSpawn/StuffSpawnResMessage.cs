using System;
using UnityEngine;

namespace MyTelepathy {
    public struct StuffSpawnResMessage {
        public int idSig;
        public Vector3 pos;

        public void Init(int idSig, Vector3 pos) {
            this.idSig = idSig;
            this.pos = pos;
        }

    }
}

