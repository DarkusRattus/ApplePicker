using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

    public static float bottomY = -20f;
	
	void Update () {
	    if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject); // Destroy the fallen Apple GameObject
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); // Get a reference to te ApplePicker component of Main Camera
            apScript.AppleDestroyed(); // Call the public AppleDestroyed method of apScript
        }
	}
}
