using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int pontos = 0;
    public int vidas = 3;

    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoVidas;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        AtualizarHUD();
    }

    public void AdicionarPontos(int valor)
    {
        pontos += valor;
        AtualizarHUD();
    }

    public void PerderVida()
    {
        vidas--;
        AtualizarHUD();

        if (vidas <= 0)
        {
            Debug.Log("Fim de jogo!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void AtualizarHUD()
    {
        textoPontos.text = "Pontos: " + pontos;
        textoVidas.text = "Vidas: " + vidas;
    }
}