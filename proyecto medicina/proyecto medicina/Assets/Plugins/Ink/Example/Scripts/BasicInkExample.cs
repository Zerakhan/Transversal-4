using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Ink.Runtime;
using System;

// This is a super bare bones example of how to play and display a ink story in Unity.
public class BasicInkExample : MonoBehaviour {
	
	void Awake () {
		// Remove the default message
		RemoveChildren();
		StartStory();
	}

	// Creates a new Story object with the compiled story which we can then play!
	void StartStory () {
		story = new Story (inkJSONAsset.text);
		RefreshView();
	}
	
	// This is the main function called every time the story changes. It does a few things:
	// Destroys all the old content and choices.
	// Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
	void RefreshView () {
		// Remove all the UI on screen
		RemoveChildren ();
		
		// Read all the content until we can't continue any more
		while (story.canContinue) {
			// Continue gets the next line of the story
			string text = story.Continue ();
			// This removes any white space from the text.
			text = text.Trim();
			// Display the text on screen!
			CreateContentView(text);
		}

		// Display all the choices, if there are any!
		if(story.currentChoices.Count > 0) {
			for (int i = 0; i < story.currentChoices.Count; i++) {
				Choice choice = story.currentChoices [i];
				Button button = CreateChoiceView (choice.text.Trim ());
                button.onClick.AddListener (delegate {
					OnClickChoiceButton (choice);
				});
			}
		}
		// If we've read all the content and there's no choices, the story is finished!
		else {
			Button choice = CreateChoiceView("End of story.\nRestart?");
			choice.onClick.AddListener(delegate{
				StartStory();
			});
		}
	}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton (Choice choice) {
		story.ChooseChoiceIndex (choice.index);
		RefreshView();
	}

	// Creates a button showing the choice text
	void CreateContentView (string text) {
        //este es el camino hacia el éxito
        float rango = UnityEngine.Random.Range(20f, 100f);
        Vector3 pos = new Vector3(71.84998f, rango, 0);

        // Asigno un rango de valores aleatorios y los guardo en un vector3 que llamo posicion
        // esa posicion va a ser la asignada a los distintos texto que estan como prefab
        Text storyText = Instantiate (textPrefab,pos,Quaternion.identity)  as Text;
        // En el instantiate se declara el prefab, la posicion que he asignado antes y Quaternion.identity que es un parametro que necesita unity
        // El texto saldra aleatoriamente en la posicion asignada en el rango random
		storyText.text = text;
		storyText.transform.SetParent (canvasTexto.transform, true);




	}

	// Creates a button showing the choice text
	Button CreateChoiceView (string text) {
		// Creates the button from a prefab
		Button choice = Instantiate (buttonPrefab) as Button;
		choice.transform.SetParent (canvas.transform, false);
		
		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text> ();
		choiceText.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent <HorizontalLayoutGroup> ();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}

	// Destroys all the children of this gameobject (all the UI)
	void RemoveChildren () {
		int childCount = canvas.transform.childCount;
		for (int i = childCount - 1; i >= 0; --i) {
			GameObject.Destroy (canvas.transform.GetChild (i).gameObject);
		}


        int childCount2 = canvasTexto.transform.childCount;
        
        for (int i = childCount2 - 1; i >= 0; --i)
        {
            GameObject.Destroy(canvasTexto.transform.GetChild(i).gameObject);
        }

    }

	
	

	[SerializeField]
	private TextAsset inkJSONAsset;
	private Story story;

	[SerializeField]
	private Canvas canvas;
    [SerializeField]
    private Canvas canvasTexto;

    // UI Prefabs
    [SerializeField]
	private Text textPrefab;
	[SerializeField]
	private Button buttonPrefab;
}