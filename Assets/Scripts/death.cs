using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public float loadDeathSceneDelay;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Death Tile")
        {
            Invoke("LoadDeathScene", loadDeathSceneDelay);
        }
    }
    void LoadDeathScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
