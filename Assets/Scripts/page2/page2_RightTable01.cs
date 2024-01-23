using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class page2_RightTable01 : MonoBehaviour
{
    float time = 0f;

    //整数数据
    public List<TextMeshProUGUI> textMeshProUGUIs;

    //百分比数据
    public TextMeshProUGUI text;
    float per;

    //旋转特效
    public Image image1;
    public Image image2;
    //波浪特效
    public Transform wave1;
    public Transform s1, e1;
    public Transform wave2;
    public Transform s2, e2;

    private void Start()
    {
        UpdateData();
    }
    private void Update()
    {
        time += Time.deltaTime;
        //旋转特效
        image1.transform.Rotate(30 * Vector3.forward * Time.deltaTime);
        image2.transform.Rotate(-30 * Vector3.forward * Time.deltaTime);
        if(time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "更新");
            time = 0f;
        }
        
    }

    public void UpdateData()
    {
        var data = Page2_ReadData.RequestData_RT01();
        if(data != null)
        {
            //更新百分比数据
            per = float.Parse(data[0]);
            UpdatePercent(per);

            //更新整数数据
            for(int i = 1; i < textMeshProUGUIs.Count + 1; i++)
            {
                textMeshProUGUIs[i-1].text = data[i];
            }
        }
        else
        {
            Debug.Log("Data errors");
        }
    }

    public void UpdatePercent(float f)
    {
        wave1.position = s1.position + (e1.position - s1.position) * f / 100;
        wave2.position = s2.position + (e2.position - s2.position) * f / 100;
        text.text = Mathf.RoundToInt(f) + "%";
    }
}
