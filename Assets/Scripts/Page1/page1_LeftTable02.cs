using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class page1_LeftTable02 : MonoBehaviour
{

    float time = 0f;

    //填充图像
    public List<Image> images;
    //图表文字数据
    public List<TextMeshProUGUI> textMeshProUGUIs;

    private void Start()
    {
        UpdateData();
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "更新");
            time = 0f;
        }
        
    }

    //更新数据
    public void UpdateData()
    {
        //读取数据
        var data = Page1_ReadData.RequestData_LT02();

        if (data != null)
        {
            for (int i = 0; i < textMeshProUGUIs.Count; i++)
            {
                images[i].fillAmount = float.Parse(data[i]) / 360;
                textMeshProUGUIs[i].text = data[i].ToString() + "°";
            }
        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }
}
