# eapp-corp-quick-start-Csharp
This a ding-talk demo project is built by netcore web for https://github.com/opendingtalk/eapp-corp-quick-start-fe.
# quick guide
Edit class Constants replace `your app key` and `your app secret`
```
    public class Constants
    {
        /**
         * 开发者后台->应用开发-企业内部应用->选择您创建的小程序->应用首页-查看详情->查看AppKey
         */
        public static readonly string APP_KEY = "your app key";
        /**
         * 开发者后台->应用开发-企业内部应用->选择您创建的小程序->应用首页-查看详情->查看AppSecret
         */
        public static readonly string APP_SECRET = "your app secret";
    }
```
Build the project and double click run.bat
# normal response 
```
{
	data:{
		code:200,
		data:{userId:"xxx123",userName:"xxx"},
		message:null
	}
}
```