using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        Scene1,
        SceneTest,
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
    public static void print()
    {
        Debug.Log(Scene.Scene1.ToString());
    }
}
