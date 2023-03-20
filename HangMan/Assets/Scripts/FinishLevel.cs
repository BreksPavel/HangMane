using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelComplete = false;
     // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelComplete)
        {
            finishSound.Play();
            levelComplete = true;
            Invoke("CompleteLevel", 0.5f);
            /*CompleteLevel();*/
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        Destroy(GameObject.FindWithTag("BG_music"));
    }
}
