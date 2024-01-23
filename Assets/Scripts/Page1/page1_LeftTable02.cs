using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class page1_LeftTable02 : MonoBehaviour
{

    float time = 0f;

    //���ͼ��
    public List<Image> images;
    //ͼ����������
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
            Debug.Log(this.name + "����");
            time = 0f;
        }
        
    }

    //��������
    public void UpdateData()
    {
        //��ȡ����
        var data = Page1_ReadData.RequestData_LT02();

        if (data != null)
        {
            for (int i = 0; i < textMeshProUGUIs.Count; i++)
            {
                images[i].fillAmount = float.Parse(data[i]) / 360;
                textMeshProUGUIs[i].text = data[i].ToString() + "��";
            }
        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }
}
