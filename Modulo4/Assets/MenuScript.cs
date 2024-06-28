using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void SairOptions(GameObject go)
    {
        go.SetActive(false);
    }

    public void AbrirOptions(GameObject go)
    {
        go.SetActive(true);
    }
}
