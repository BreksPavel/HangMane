using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int items = 0;
    [SerializeField] private Text score;
    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collection item"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            items++;
            score.text = "Score: " + items;
        }
    }
}
