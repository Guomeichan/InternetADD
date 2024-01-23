using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class page1_LeftTable03 : MonoBehaviour
{

    float time = 0f;

    //图表数据
    public List<TextMeshProUGUI> textMeshProUGUIs;
    public Text text;

    void Start()
    {
        UpdateData();
    }


    void Update()
    {
        time += Time.deltaTime;
        //两秒更新一次
        if (time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "更新");
            time = 0f;
        }
        
    }

    public void UpdateData()
    {
        var data = Page1_ReadData.RequestData_LT03();
        if (data != null)
        {
            for (int i = 0; i < textMeshProUGUIs.Count - 1; i++)
            {
                textMeshProUGUIs[i].text = data[i];
            }
            text.text = data[data.Count - 1];
        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }
}
