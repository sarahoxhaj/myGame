using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fighterDeath : MonoBehaviour
{
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1);
     SceneManager.LoadScene("endGame");

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            anim.SetTrigger("death");
            StartCoroutine(WaitForSceneLoad());
        }
    }

}
