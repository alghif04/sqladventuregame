using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public void PlayLevel()
    {
        SceneManager.LoadScene("Level-1");
    }
}
