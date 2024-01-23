using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;


public delegate List<string> Page1_ReadData_LT01();
public class page1_LeftTable01 : MonoBehaviour
{
 
	public bool b=true;
	public float speed=0.5f;
	float time =0f;

	//图表数据
	public TextMeshProUGUI L_progress;
	public TextMeshProUGUI R_progress;
    public Image L_image;
    public Image R_image;
    private void Start()
    {
		UpdateData();
    }
    void Update()
	{
		time += Time.deltaTime;
		//两秒更新一次
		if(time >= 2f )
		{
            UpdateData();
			Debug.Log(this.name + "更新");
			time = 0f;
        }
	}

	//更新图表数据
	public void UpdateData()
	{
		//读数据
		var data = Page1_ReadData.RequestData_LT01();

        if ( data != null )
		{
            L_image.fillAmount = float.Parse(data[0]) / 100;
            R_image.fillAmount = float.Parse(data[1]) / 100;
            L_progress.text = data[0] + "%";
            R_progress.text = data[1] + "%";
		}
		else
		{
            Debug.Log(this.name + "Data errors");
        }
    }
}
