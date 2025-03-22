using UnityEngine;
using TMPro;

public class PlayerCollision_PNJ2 : MonoBehaviour
{

    private AudioSource CommentairePatron;

    private void Start()
    {
        CommentairePatron = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!CommentairePatron.isPlaying)
            {
                CommentairePatron.Play();
            }
        }
    }
}
