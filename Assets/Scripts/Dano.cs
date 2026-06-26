using UnityEngine;

public class Dano : MonoBehaviour
{
    public AudioClip somDano;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (somDano != null)
            {
                AudioSource.PlayClipAtPoint(somDano, transform.position);
            }

            GameManager.instance.PerderVida();
        }
    }
}