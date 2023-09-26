using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRButtonInteraction : MonoBehaviour
{
    public string targetSceneName; // The name of the scene you want to load.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VRController")) // Adjust the tag according to your VR controllers.
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
} 