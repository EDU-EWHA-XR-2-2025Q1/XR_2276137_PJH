using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour
{
    public void OnClick_LoadScene()
    {
        SceneManager.LoadScene(0); // ¾À ÀÎµ¦½º 0 (¶Ç´Â ¾À ÀÌ¸§µµ °¡´É)
    }
}
