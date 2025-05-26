
namespace MyTelepathy {

    public struct BulletDestoryResMessage {
        public IDSignature idSig;

        public void Init(IDSignature iDSignature) {
            this.idSig = iDSignature;
        }
    }
}