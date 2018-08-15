using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Sobre()
    {
        SceneManager.LoadScene("Sobre");
    }


    void Update()
    {


        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();

        }

    }
}