using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class page2_LeftTable02 : MonoBehaviour
{

    public List<TextMeshProUGUI> textMeshPros;
    //百分比
    public Image image;
    public TextMeshProUGUI progress;

    private void Start()
    {
        for (int i = 0; i < textMeshPros.Count; i++)
        {
            textMeshPros[i].text = "0";
        }
    }

    private void Update()
    {
        UpdateData();
    }

    public void UpdateData()
    {
        var data = Page2_ReadData.RequestData_LT02();

        if(data!=null)
        {
            //数据1
            int len = data[0].Length;
            var num = data[0].ToList<char>();
            num.Reverse();
            for(int i = 0; i < len; i++)
            {
                textMeshPros[i].text = num[i].ToString();
            }

            //数据2
            float m1 = float.Parse(data[0]);
            float m2 = float.Parse(data[1]);
            float percentage = m1 / m2;
            image.fillAmount = percentage;
            progress.text = (percentage * 100).ToString() + "%";

        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }


}
