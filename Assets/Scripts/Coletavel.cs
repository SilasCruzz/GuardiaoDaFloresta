using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int valor = 1;
    public AudioClip somColeta;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.AdicionarPontos(valor);

            if (somColeta != null)
            {
                AudioSource.PlayClipAtPoint(somColeta, transform.position);
            }

            Destroy(gameObject);
        }
    }
}