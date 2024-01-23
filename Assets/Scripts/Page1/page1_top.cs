using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class page1_top : MonoBehaviour
{

    //显示时间
    public TextMeshProUGUI text_time;

    void Update()
    {
        text_time.text = DateTime.Now.ToString();
    }
    //退出应用
    public void Close()
    {
        Application.Quit();
    }

}
