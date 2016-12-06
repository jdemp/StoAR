using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class CanvasReposition : MonoBehaviour {
    public SteamVR_Camera player;

    // Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (new Vector3 (player.transform.position.x, 3.75f, player.transform.position.z));
    }
}
