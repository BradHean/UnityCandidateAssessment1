using UnityEngine;

public class validation : MonoBehaviour
{
	//these could be private and serialized, but left as is because I`m unsure of their usage
	public GameObject param1, param2, param3, param4;

	//exit quicker and reduced nested IF's for better readability
	private void Start()
	{
		if (param1 == null)
		{
			ShowDebug("param1");
			return;
		}
		if (param2 == null)
		{
			ShowDebug("param2");
			return;
		}
		//removed unused variable "stuffDone"
		DoSomeStuff(param1, param2);
		if (param3 == null)
		{
			ShowDebug("param3");
			return;
		}
		//removed unused variable "newObject"
		DoMoreStuff(param3);
		if (param4 == null)
		{
			ShowDebug("param4");
			return;
		}
		print("Success");
	}

	//reuse code and added more info
	private void ShowDebug(string reference)
	{
		Debug.LogError("Reference invalid for " + reference);
	}

	//change variable names to avoid confusion
	private bool DoSomeStuff(GameObject objectOne, GameObject objectTwo)
	{
		return true;
	}

	private GameObject DoMoreStuff(GameObject go)
	{
		return Instantiate(go);
	}
}
