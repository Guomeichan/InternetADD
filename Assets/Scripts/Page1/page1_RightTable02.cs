﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class page1_RightTable02 : MonoBehaviour
{
 
     public bool b=true;
	 public Slider slider;
	 public float speed=0.5f;

  float time =0f;
  
  void Start()
  {
	  
	slider = GetComponent<Slider>();
  }
  
    void Update()
    {
		if(b)
		{
			time+=Time.deltaTime*speed;
			slider.value = time;
			
        if(time>1)
		{
             
			time=0;
		}
    }
	}
	
	
}
