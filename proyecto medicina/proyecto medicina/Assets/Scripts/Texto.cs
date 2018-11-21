using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Texto : MonoBehaviour
{
	public InputField txtRef;
	public string typedText;

	void Update() 
	{
		typedText = txtRef.text;
    }
}
