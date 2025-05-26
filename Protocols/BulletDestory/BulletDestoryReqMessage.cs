namespace MyTelepathy {

    public struct BulletDestoryReqMessage {
        public int idSig;

        public void Init(int iDSignature) {
            this.idSig = iDSignature;
        }
    }
}