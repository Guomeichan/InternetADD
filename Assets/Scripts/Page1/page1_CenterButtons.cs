using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class page1_CenterButtons : MonoBehaviour
{
    float time = 0f;

    //图表数据
    public List<TextMeshProUGUI> textMeshProUGUIs;


    void Start()
    {
        UpdateData();
    }


    void Update()
    {
        time += Time.deltaTime;
        if(time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "更新");
            time = 0f;
        }
    }

    public void UpdateData()
    {
        var data = Page1_ReadData.RequestData_CBS();
        if (data != null)
        {
            for (int i = 0; i < textMeshProUGUIs.Count; i++) 
            {
                textMeshProUGUIs[i].text = data[i];
            }
        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }
}
