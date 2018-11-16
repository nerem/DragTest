using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ItemSlotData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public int Item { get; set; }
	public int Amount { get; set; }

	void Awake()
	{
		this.Item = 0;
		this.Amount = 0;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("DRAG START");
	}

	public void OnDrag(PointerEventData eventData)
	{
		Debug.Log("DRAGGING");
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log("END DRAG");
	}
}
