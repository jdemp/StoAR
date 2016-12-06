using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoAR_UI_Interactions : MonoBehaviour {
	private CanvasGroup CanvasGroup;

	void Start()
	{
		CanvasGroup = GetComponent<CanvasGroup> ();
	}

	public void HideCanvas()
	{
		CanvasGroup.alpha = 0;
		CanvasGroup.interactable = false;
		CanvasGroup.blocksRaycasts = false;
	}

}
