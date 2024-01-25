using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kockagomb : MonoBehaviour
{
    // Start is called before the first frame update
    public void scene(string x)
    {
        SceneManager.LoadScene(x);

    }
}
