using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ApplePicker : MonoBehaviour {

    public GameObject basketPrefab;
    public List<GameObject> basketList;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

	void Start () {
        basketList = new List<GameObject>();
	    for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
	}

    public void AppleDestroyed()
    {
        // Destroy all of the falling Apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }

        // Destroy one of the Baskets if you mess up
        int basketIndex = basketList.Count - 1; // Get the index of the last Basket in the basketList
        GameObject tBasketGO = basketList[basketIndex]; // Get a reference to that Basket GameObject
        basketList.RemoveAt(basketIndex); // Remove the Basket from the List
        Destroy(tBasketGO); // Destroy the Basket GameObject

    }
 
}
