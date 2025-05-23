namespace MyTelepathy {

    public static class MessageConst {
        public const int SpawnRole_Req = 10;
        public const int SpawnRole_Res = 11;
        public const int SpawnRole_Bro = 12;
        public const int Test_Req = 20;
        public const int Test_Res = 21;
        public const int Test_Bro = 22;
        public const int Move_Req = 30;  // 客户端→服务端的移动请求
        public const int Move_res = 31;
        public const int Move_Bro = 32;  // 服务端→客户端的移动广播
        public const int SpawnBullet_Req = 40;  // 客户端→服务端的子弹请求
        public const int SpawnBullet_Res = 41;  // 服务端→客户端的子弹响应
        public const int SpawnBullet_Bro = 42;  // 服务端→客户端的子弹广播

    }
}