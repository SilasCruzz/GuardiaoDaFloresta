using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void CarregarFase1()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}