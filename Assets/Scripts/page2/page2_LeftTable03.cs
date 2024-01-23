using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class page2_LeftTable03 : MonoBehaviour
{
    public List<TextMeshProUGUI> textMeshProUGUIs;

    float time = 0f;

    private void Start()
    {
        UpdateData();
    }

    private void Update()
    {
        time += Time.deltaTime;
        if(time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "����");
            time = 0f;
        }
    }


    public void UpdateData()
    {
        var data = Page2_ReadData.RequestData_LT03();

        if(data != null)
        {
            for(int i = 0;i< textMeshProUGUIs.Count; i++)
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
