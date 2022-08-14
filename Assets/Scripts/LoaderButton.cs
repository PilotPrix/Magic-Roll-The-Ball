using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoaderButton : MonoBehaviour
{
    public Loader.Scene nextLevelScene;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() => { Loader.Load(nextLevelScene); });
    }
}
