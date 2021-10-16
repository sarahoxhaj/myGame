using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class complete : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = true;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("complete");

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Fighter" && levelCompleted)
        {
            finishSound.Play();
            levelCompleted = false;
            StartCoroutine(WaitForSceneLoad());
        }
    }

    
}
