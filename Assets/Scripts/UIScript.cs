using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Sprite emptyCannonball;
    private int currentID = 0;
    private void Start()
    {
        currentID = this.gameObject.transform.childCount - 1;
    }
    public void decrementAmmo() {
        if (currentID >= 0) {
            GameObject ammoUsed = transform.GetChild(currentID).gameObject;
            ammoUsed.GetComponent<Image>().sprite = emptyCannonball;
            currentID--;
        }
    }
}
