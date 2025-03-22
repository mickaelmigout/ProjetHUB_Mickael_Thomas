using UnityEngine;
using TMPro;

public class PlayerCollision_PNJ3 : MonoBehaviour
{

    private AudioSource MarchandVaisseau;

    private void Start()
    {
        MarchandVaisseau = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!MarchandVaisseau.isPlaying)
            {
                MarchandVaisseau.Play();
            }
        }
    }
}
