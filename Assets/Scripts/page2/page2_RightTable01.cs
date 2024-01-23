using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class page2_RightTable01 : MonoBehaviour
{
    float time = 0f;

    //��������
    public List<TextMeshProUGUI> textMeshProUGUIs;

    //�ٷֱ�����
    public TextMeshProUGUI text;
    float per;

    //��ת��Ч
    public Image image1;
    public Image image2;
    //������Ч
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
        //��ת��Ч
        image1.transform.Rotate(30 * Vector3.forward * Time.deltaTime);
        image2.transform.Rotate(-30 * Vector3.forward * Time.deltaTime);
        if(time > 2f)
        {
            UpdateData();
            Debug.Log(this.name + "����");
            time = 0f;
        }
        
    }

    public void UpdateData()
    {
        var data = Page2_ReadData.RequestData_RT01();
        if(data != null)
        {
            //���°ٷֱ�����
            per = float.Parse(data[0]);
            UpdatePercent(per);

            //������������
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
