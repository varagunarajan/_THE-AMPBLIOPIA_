using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the XR rig (player) entered the trigger zone
        if (other.CompareTag("Player"))
        {
            // Load the 'final' scene
            SceneManager.LoadScene("ampliopia buttons");
        }
    }
}

