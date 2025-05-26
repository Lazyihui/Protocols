namespace MyTelepathy {

    public struct BulletDestoryReqMessage {
        public IDSignature idSig;

        public void Init(IDSignature iDSignature) {
            this.idSig = iDSignature;
        }
    }
}