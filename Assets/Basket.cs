using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Basket : MonoBehaviour {

    public Text scoreGT;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter"); // Find a reference to the ScoreCounter object
        scoreGT = scoreGO.GetComponent<Text>(); // Get the text component of the GameObject
        scoreGT.text = "0"; // Set the starting number of points to 0
    }

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

    void OnCollisionEnter(Collision coll)
    {
        // Find out what hit the Basket
        GameObject collideWith = coll.gameObject;
        if (collideWith.tag == "Apple")
        {
            Destroy(collideWith);
        }

        int score = int.Parse(scoreGT.text); // Parse the text of scoreGT to an integer
        score += 100; // Add 100 to that video
        scoreGT.text = score.ToString(); // Convert the score to a string and assign it to scoreGT's text

        // Track the high score
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }

}
