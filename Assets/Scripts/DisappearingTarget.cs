using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisappearingTarget : MonoBehaviour
{
    public GameObject locationList;
    private int previousID = -1;
    private static GameObject target;
    public AudioSource hitAudio;
    private void Awake()
    {
        //lets me reference the previous location. 
        //Code snippet from: https://answers.unity.com/questions/982403/how-to-not-duplicate-game-objects-on-dontdestroyon.html
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(locationList);

        if (target == null)
        {
            target = this.gameObject;
            this.setPosition();
        }
        else {
            Destroy(this.gameObject);
            Destroy(locationList);
        }
    }
    private void setPosition()
    {
        //Places the target at a random location selected from the existing set of places
        //Code help found at https://answers.unity.com/questions/1448283/randomly-choose-children-gameobjects-in-a-for-loop.html
        int newLocationID;
        do {
            newLocationID = Random.Range(0, locationList.transform.childCount);
        } while (newLocationID == previousID);
        previousID = newLocationID;
        Transform newLocation = locationList.transform.GetChild(newLocationID).transform;
        gameObject.transform.SetPositionAndRotation(newLocation.transform.position, newLocation.transform.rotation);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject CannonBallCollision = other.gameObject;
        if (CannonBallCollision.tag == "cannonball")
        {

            hitAudio.GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("CannonRoom");
            this.setPosition();
        }

    }
}
