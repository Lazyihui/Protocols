using System;

namespace MyTelepathy {

    public class IDServer {
        public int roleID;
        public int bulletID;

        public int StuffID;

        public IDServer() {
            roleID = 0;
            bulletID = 0;
            StuffID = 0;
        }

        public int PickRoleID() {
            return ++roleID;
        }
        public int PickBulletID() {
            return ++bulletID;
        }
        public int PickStuffID() {
            return ++StuffID;
        }
    }
}