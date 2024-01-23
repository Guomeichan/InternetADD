using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class page2_RightTable02 : MonoBehaviour
{
    public List<Image> images;

    public List<TextMeshProUGUI> textMeshProUGUIs;

    float time = 0f;

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
            Debug.Log(this.name + "¸üÐÂ");
            time = 0f;
        }
    }

    public void UpdateData()
    {
        var data = Page2_ReadData.RequestData_RT02();
        if (data != null)
        {
            for(int i = 0;i<textMeshProUGUIs.Count;i++)
            {
                images[i].fillAmount = float.Parse(data[i]) / float.Parse(data[data.Count - 1]);
                textMeshProUGUIs[i].text = data[i];
            }
        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }
}
