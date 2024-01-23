
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
public class page1_CenterTable : MonoBehaviour
{

    float time = 0f;
    //环状图片
    public Image a, b, c, d;
    //总数
    public TextMeshProUGUI total;
    //百分比
    public List<TextMeshProUGUI> textMeshProUGUIs1;
    //整数
    public List<TextMeshProUGUI> textMeshProUGUIs2;

    private void Start()
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
        var data = Page1_ReadData.RequestData_CT01();

        if (data != null)
        {
            //总数
            float totalNum = 0f;
            for (int i = 0; i < data.Count; i++) 
            {
                totalNum += float.Parse(data[i]);
            }
            total.text = totalNum.ToString();
            //整数
            for (int i = 0; i < textMeshProUGUIs2.Count; i++) 
            {
                textMeshProUGUIs2[i].text = data[i].ToString();
            }
            //百分比 + 环状图片
            UpdatePercent(float.Parse(data[0]), float.Parse(data[1]), float.Parse(data[2]), float.Parse(data[3]));
        }
    }

    public void UpdatePercent(float n1, float n2, float n3, float n4)
    {
        float sum = n1 + n2 + n3+n4;
        float p1 = n1 / sum;
        float p2 = n2 / sum;
        float p3 = n3 / sum;
        float p4 = n4 / sum;

        a.fillAmount = p1;
        b.fillAmount = p2;

        b.transform.localEulerAngles = -new Vector3(0, 0, 360f * p1);
 

        c.fillAmount = p3;
        c.transform.localEulerAngles = -new Vector3(0, 0,  360f * p1) - new Vector3(0, 0, 360f * p2);
 
        d.fillAmount = p4;
        d.transform.localEulerAngles = -new Vector3(0, 0,360f * p1) - new Vector3(0, 0,360f * p2) - new Vector3(0, 0, 360 * p3);
        textMeshProUGUIs1[0].text = (int)(p1 * 100) + "%";
        textMeshProUGUIs1[1].text = (int)(p2 * 100) + "%";
        textMeshProUGUIs1[2].text = (int)(p3 * 100) + "%";
        textMeshProUGUIs1[3].text = (int)(p4 * 100) + "%";
    }
}
