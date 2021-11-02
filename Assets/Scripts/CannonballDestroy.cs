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
            //Separates smoke trail from cannonball so that it stays. Code help from: https://answers.unity.com/questions/167827/particles-disappear-when-game-object-is-destroyed.html
            ParticleSystem emitter = cannonball.transform.GetChild(0).GetComponent<ParticleSystem>();
            emitter.transform.parent = null;
            emitter.Stop();

            Destroy(cannonball);
            if (gameFire.ammoRemaining < 1 && --gameFire.existingBalls < 1) {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
