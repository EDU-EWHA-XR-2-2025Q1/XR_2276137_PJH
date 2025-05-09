using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HW02_Scene1 : MonoBehaviour
{
    string UserInput = "";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    public void OnClick_AssignData(TMP_InputField InputField)
    {
        UserInput = InputField.text;
    }

    public void OnClick_Display_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
    }

    public void OnClick_DisplayAndSet_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
        PlayerPrefs.SetString("Input", Message.text);
    }


    public void OnClick_LoadScene(Object SceneObject)
    {
        StartCoroutine(LoadSceneAfterDelay(SceneObject.name, 2f)); // 2초 후에 씬 전환
    }

    private IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
