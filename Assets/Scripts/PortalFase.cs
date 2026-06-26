using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalFase : MonoBehaviour
{
    public string nomeDaProximaFase;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(nomeDaProximaFase);
        }
    }
}