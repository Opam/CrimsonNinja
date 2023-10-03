using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public void end()
    {
        gameObject.SetActive(true);
    }



    public void button_restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void button_exit()
    {
        SceneManager.LoadScene("1");
    }
}
