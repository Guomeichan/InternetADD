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
        //����Ҫ������Ӧ�ó���
        p.StartInfo.FileName = "cmd.exe";
        //�Ƿ�ʹ�ò���ϵͳshell����
        p.StartInfo.UseShellExecute = false;
        // �������Ե��ó����������Ϣ
        p.StartInfo.RedirectStandardInput = true;
        //�����Ϣ
        p.StartInfo.RedirectStandardOutput = true;
        // �������
        p.StartInfo.RedirectStandardError = true;
        //����ʾ���򴰿�
        p.StartInfo.CreateNoWindow = true;
        //��������
        p.Start();
        //��cmd���ڷ���������Ϣ
        p.StandardInput.WriteLine(strInput + "&exit");
        p.StandardInput.AutoFlush = true;
        //��ȡ�����Ϣ
        string strOuput = p.StandardOutput.ReadToEnd();
        //�ȴ�����ִ�����˳�����
        p.WaitForExit();
        p.Close();
        Console.WriteLine(strOuput);
        Console.ReadKey();
    }

}
