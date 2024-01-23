using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class page1_RightTable03 : MonoBehaviour
{

    float time = 0f;

    //ͼ������
    public List<TextMeshProUGUI> textMeshProUGUIs;


    void Start()
    {
        UpdateData();
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "����");
            time = 0f;
        }
    }


    public void UpdateData()
    {
        //��ȡ����
        var data = Page1_ReadData.RequestData_RT03();

        if (data != null)
        {
            for(int i = 0;i < textMeshProUGUIs.Count; i++)
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
