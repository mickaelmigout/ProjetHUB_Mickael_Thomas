using UnityEngine;
using TMPro;

public class PlayerCollision_PNJ4 : MonoBehaviour
{

    private AudioSource MarchandPerso;

    private void Start()
    {
        MarchandPerso = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!MarchandPerso.isPlaying)
            {
                MarchandPerso.Play();
            }
        }
    }
}
