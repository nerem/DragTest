using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragImageAdder : MonoBehaviour {



	public GameObject dragPrefab;

	static int count = 0;

	public void OnClick()
	{
		Debug.Log("Clicked Button!");
		GameObject go = Instantiate(dragPrefab, this.transform);
		count++; 
		go.transform.localPosition = new Vector3(92f, -count * 105f, 0f);

		GetComponent<RectTransform>().sizeDelta += new Vector2(0, 100f);
	}
}
