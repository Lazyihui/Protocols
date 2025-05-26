namespace MyTelepathy {

    public static class MessageConst {
        public const int SpawnRole_Req = 10;
        public const int SpawnRole_Res = 11;
        public const int SpawnRole_Bro = 12;
        public const int Test_Req = 20;
        public const int Test_Res = 21;
        public const int Test_Bro = 22;
        public const int Move_Req = 30;  // 客户端→服务端的移动请求
        public const int Move_res = 31; // 服务端→客户端的移动响应
        public const int Move_Bro = 32;  // 服务端→客户端的移动广播
        public const int BulletSpawn_Req = 40;
        public const int BulletSpawn_Res = 41;
        public const int BulletSpawn_Bro = 42;
        public const int BulletMove_Req = 50;
        public const int BulletMove_Res = 51;
        public const int BulletMove_Bro = 52;
        public const int BulletDestory_Req = 60;
        public const int BulletDestory_Res = 61;
        public const int BulletDestory_Bro = 62;

        public const int StuffSpawn_Req = 70;
        public const int StuffSpawn_Res = 71;
        public const int StuffSpawn_Bro = 72;

        public const int StuffDestory_Req = 80;
        public const int StuffDestory_Res = 81;
        public const int StuffDestory_Bro = 82;

        // 
        public const int StuffMove_Req = 90; // 客户端→服务端的物品移动请求
        public const int StuffMove_Res = 91; // 服务端→客户端的物品移动响应
        public const int StuffMove_Bro = 92; // 服务端→客户端的物品移动广播
    }
}