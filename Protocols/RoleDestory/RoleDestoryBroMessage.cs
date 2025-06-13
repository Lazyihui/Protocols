
namespace MyTelepathy {

    public struct RoleDestoryReqMessage {
        public string roleName;
        public int idSig;

        public void Init(int idSig) {
            this.idSig = idSig;
        }

    }
}