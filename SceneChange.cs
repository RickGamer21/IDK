using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string scenceName;

    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(scenceName);
    }


}