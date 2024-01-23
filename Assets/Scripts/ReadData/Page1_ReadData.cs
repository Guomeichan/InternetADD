using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Page1_ReadData
{
    //左1图表
    public static List<string> RequestData_LT01()
    {
        var data = new List<string>() { "50", "10" };
        return data;
    }
    //左2图表
    public static List<string> RequestData_LT02()
    {
        var data = new List<string>() { "53", "148", "89", "227", "121", "74" };
        return data;
    }
    //左3图表
    public static List<string> RequestData_LT03()
    {
        var data = new List<string>() { "1234", "4556", "9290", "1111", "78" };
        return data;
    }
    //右1图表
    public static List<string> RequestData_RT01()
    {
        var data = new List<string>() { "3214", "8532", "1221", "6534" };
        return data; 
    }
    //右2图表
    public static List<string> RequestData_RT02()
    {
        var data = new List<string>();
        return data;
    }
    //右3图表
    public static List<string> RequestData_RT03()
    {
        var data = new List<string>() { "110", "112", "114", "120", "911", "119" };
        return data;
    }
    //中间按钮
    public static List<string> RequestData_CBS()
    {
        var data = new List<string>() { "92340", "12341", "23745", "15643" };
        return data;
    }
    //中间图表
    public static List<string> RequestData_CT01()
    {
        var data = new List<string>() { "250", "481", "111", "158" };
        return data;
    }
}
