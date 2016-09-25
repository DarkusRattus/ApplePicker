using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos2D = Input.mousePosition; // Get current screen position of the mouse from input
        mousePos2D.z = -Camera.main.transform.position.z; // The Camera's Z position sets how far to push the mouse into 3D
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); // Convert the point from 2D screen space into 3D game world space

        // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

	}


}
