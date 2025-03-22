using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{

    public Transform Player;
    public Canvas canvasPNJ;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasPNJ.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasPNJ.gameObject.SetActive(false);
        }
    }
}
