using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    private int scene;
    public void Move(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
