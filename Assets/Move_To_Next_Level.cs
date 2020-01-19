using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_To_Next_Level : MonoBehaviour {

    [SerializeField] private string nextLevel;

    void OnTriggerEnter2D(Collider2D witch)
    {
        Debug.Log("collided...");
        if (witch.CompareTag("Player")) {
            Debug.Log("collided with player");
            SceneManager.LoadScene(nextLevel);
        }
        
    }
}
