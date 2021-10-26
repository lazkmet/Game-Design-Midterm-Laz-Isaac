using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CannonballDestroy : MonoBehaviour
{
    public Fire gameFire;
    private void OnCollisionEnter(Collision coll)
    {
        GameObject cannonball = coll.gameObject;
        if (cannonball.tag == "cannonball") {
            Destroy(cannonball);
            if (gameFire.ammoRemaining < 1 && --gameFire.existingBalls < 1) {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
