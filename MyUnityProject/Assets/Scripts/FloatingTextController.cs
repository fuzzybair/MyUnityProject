using UnityEngine;

public class FloatingTextController : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		TextMesh floatingText = gameObject.GetComponent<TextMesh>();
		floatingText.text = GetUIText();
	}


	private string GetUIText()
	{
		return "This is a test";
	}

	// Update is called once per frame
	void Update()
	{

	}
}
