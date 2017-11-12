using MyUnityProject.Support;
using UnityEngine;

public class FloatingTextController : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		TextMesh floatingText = gameObject.GetComponent<TextMesh>();
		IMyText myText = new MyText();
		floatingText.text = myText.GetUIText();
	}



	// Update is called once per frame
	void Update()
	{

	}
}
