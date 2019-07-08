﻿/****************************************************
	文件：ServerRoot.cs
	作者：朱龙飞
	邮箱: 398670608@qq.com
	日期：2019/07/08 9:58   	
	功能：服务器初始化
*****************************************************/
public class ServerRoot
{
    private static ServerRoot instance = null;

    public static ServerRoot Instance {
        get {
            if (instance == null)
            {
                instance = new ServerRoot();
            }
            return instance;
        }
    }

    public  void Init()
    {
        //数据层Todo

        //服务层
        NetSvc.Instance.Init();

        //业务系统层
        LoginSys.Instance.Init();
    }
}