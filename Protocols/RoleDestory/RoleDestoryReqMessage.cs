
namespace MyTelepathy {

    public struct RoleDestoryBroMessage {
        
        public string roleName;
        public int idSig;

        public void Init(string roleName) {
            this.roleName = roleName;
        }

    }
}