using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	/*public static GameObject itemBeingDragged;
	Vector3 startPosition;
	Transform startParent;*/

	public int index;
	static bool beingDragged = false;
	static int dragFrom;

	public void OnBeginDrag(PointerEventData eventData) {
		beingDragged = true;
		dragFrom = index;
	}
	public void OnDrag(PointerEventData eventData) {
		transform.position += (Vector3)eventData.delta;
	}
	public void OnEndDrag(PointerEventData eventData) {
		beingDragged = false;
	}
	/*
	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData) {
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData) {
		transform.position = eventData.position;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData) {
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if (transform.parent = startParent) {
			transform.position = startPosition;
		}
	}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
*/
}
