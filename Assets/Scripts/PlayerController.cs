using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float velocidadeCorrida = 8f;
    public float forcaPulo = 12f;
    public float velocidadeEscalada = 4f;

    private Rigidbody2D rb;
    private bool noChao;
    private bool podeEscalar;
    private float movimento;
    private float movimentoVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimento = Input.GetAxisRaw("Horizontal");
        movimentoVertical = Input.GetAxisRaw("Vertical");

        float velocidadeAtual = Input.GetKey(KeyCode.LeftShift) ? velocidadeCorrida : velocidade;

        rb.linearVelocity = new Vector2(movimento * velocidadeAtual, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && noChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
        }

        if (podeEscalar)
        {
            rb.gravityScale = 0;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, movimentoVertical * velocidadeEscalada);
        }
        else
        {
            rb.gravityScale = 3;
        }

        if (movimento > 0)
{
    transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
}
else if (movimento < 0)
{
    transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Escada"))
        {
            podeEscalar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Escada"))
        {
            podeEscalar = false;
        }
    }
}