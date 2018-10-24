using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text : MonoBehaviour
{
	public InputField txtRef;
	private Text mytext; 
	public Text mytext2;
	float timeLeft = 15.0f;
    
	public string typedText;

	bool hasChanged = false;

    
    private void Awake()
	{
		mytext = GetComponent<Text> ();
	}
	void Update() 
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft > 0) 
		{
			mytext.text = txtRef.text;
		} 
		else if (timeLeft < 0 && !hasChanged) 
		{
			hasChanged = true;
			typedText = txtRef.text;
			txtRef.text = null;
            //Wait aqui
			mytext.text = null;
            //Wait aqui
			mytext2.gameObject.SetActive (true);
			mytext2.text = "ERROR! ERROR! Write the same sentence again";
            //Wait aqui
            mytext2.color = Color.green;
			Invoke ("DestroyError", 3f);

		}
		else if (timeLeft < 0 && hasChanged)
		{
		    SceneManager.LoadScene("Canvas2");
            
		}
	} 

	void DestroyError()
	{
		mytext2.gameObject.SetActive(false);
		timeLeft = 5f;
	}
}
