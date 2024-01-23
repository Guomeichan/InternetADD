using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RobotRun : MonoBehaviour
{

    private void Start()
    {
        func();
    }

    void Update()
    {
        /*this.transform.Rotate(Vector3.up, 45 * Time.deltaTime, Space.Self);*/
        if(Input.GetKeyDown(KeyCode.A))
        {
            func();
        }
    }
    public void func()
    {
        string cmd = "curl -X POST http://localhost:5000/predict";
        CMD(cmd);
    }
    public void CMD(string input)
    {
        string strInput = input;
        Process p = new Process();
        //设置要启动的应用程序
        p.StartInfo.FileName = "cmd.exe";
        //是否使用操作系统shell启动
        p.StartInfo.UseShellExecute = false;
        // 接受来自调用程序的输入信息
        p.StartInfo.RedirectStandardInput = true;
        //输出信息
        p.StartInfo.RedirectStandardOutput = true;
        // 输出错误
        p.StartInfo.RedirectStandardError = true;
        //不显示程序窗口
        p.StartInfo.CreateNoWindow = true;
        //启动程序
        p.Start();
        //向cmd窗口发送输入信息
        p.StandardInput.WriteLine(strInput + "&exit");
        p.StandardInput.AutoFlush = true;
        //获取输出信息
        string strOuput = p.StandardOutput.ReadToEnd();
        //等待程序执行完退出进程
        p.WaitForExit();
        p.Close();
        Console.WriteLine(strOuput);
        Console.ReadKey();
    }

}
