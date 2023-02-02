using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void LivingRoom()
    {
        LoadScene("Skybox-LivingRoom");
    }

    public void Mazzanine()
    {
        LoadScene("Skybox-Mezzanine");
    }

    public void Cube()
    {
        LoadScene("Skybox-Cube");
    }

    public void Cantine()
    {
        LoadScene("Skybox-Cantina");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
