using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    void Update()
    {
        var Sceane = gameObject.GetComponent<PlayerHealth>();
        if (Input.GetKeyDown(KeyCode.Space) && Sceane.RepearScene == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
