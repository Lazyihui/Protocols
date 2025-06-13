
namespace MyTelepathy {

    public struct RoleDestoryBroMessage {

        public string roleName;
        public int idSig;

        public void Init(int idSig, string roleName) {
            this.idSig = idSig;
            this.roleName = roleName;
        }

    }
}