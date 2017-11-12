using UnityEngine;

public class FloatingTextController : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		TextMesh floatingText = gameObject.GetComponent<TextMesh>();
#if UNITY_WSA
		var myText = new MyUnityProject.Support.UWP.MyText();
		floatingText.text = myText.GetUIText();
#endif
#if UNITY_EDITOR
		//var myText = new MyUnityProject.Support.Editor.MyEditorText();
		//floatingText.text = myText.GetUIText();
#endif
	}



	// Update is called once per frame
	void Update()
	{

	}
}
