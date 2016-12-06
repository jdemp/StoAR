using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class CanvasReposition : MonoBehaviour {
	private GameObject player;

    // Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("CameraRig");
    }

	// Update is called once per frame
	void Update () {
		float distanceX = player.transform.position.x - transform.position.x;
		float distanceZ = player.transform.position.z - transform.position.z;
		transform.LookAt (new Vector3 (transform.position.x - distanceX, 3.75f, transform.position.z - distanceZ));
    }
}
