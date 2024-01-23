using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class page2_LeftTable01 : MonoBehaviour
{
    public Text text;
    public TMP_Dropdown dropdown;

    float time = 0f;

    private void Start()
    {
        List<string> list = new List<string>() { "111", "222", "111", "222", "111", "222" };
        dropdown.AddOptions(list);
    }

    private void Update()
    {
        
    }

    public void UpdateData()
    {
        var data = Page2_ReadData.RequestData_LT01();

        if (data != null)
        {

        }
        else
        {
            Debug.Log(this.name + "Data errors");
        }
    }

}
