using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class CanvasReposition : MonoBehaviour {
    //public Canvas samsungCanvas;
    public SteamVR_Camera player;
    //public <SOME_TYPE> laptop;
    

    // Use this for initialization
	void Start () {
	           
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.LookRotation(transform.position - player.transform.position);
        //transform.position = new Vector3(0.9 * laptop.x + 0.1 * player.transform.position.x,
        //                                 0.9 * laptop.y + 0.1 * player.transform.position.y,
        //                                 0.9 * laptop.z + 0.1 * player.transform.position.z);
    }
}
