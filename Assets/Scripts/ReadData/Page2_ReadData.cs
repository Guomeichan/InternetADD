using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Page2_ReadData
{
    //左1图表
    public static List<string> RequestData_LT01()
    {
        var data = new List<string>() { "11123", "50000" };
        return data;
    }
    //左2图表
    public static List<string> RequestData_LT02()
    {
        var data = new List<string>() { "11123", "50000" };
        return data;
    }
    //左3图表
    public static List<string> RequestData_LT03()
    {
        var data = new List<string>() { "23", "510", "246", "134", "523", "523" };
        return data;
    }
    //中1图表
    public static List<string> RequestData_CB1()
    {
        var data = new List<string>() { "111", "222", "333", "444" };
        return data;
    }
    //右1图表
    public static List<string> RequestData_RT01()
    {
        var data = new List<string>() { "50", "222", "333", "444" };
        return data;
    }
    //右2图表
    public static List<string> RequestData_RT02()
    {
        var data = new List<string>() { "666", "555", "444", "333", "222", "1000" };
        return data;
    }
}
