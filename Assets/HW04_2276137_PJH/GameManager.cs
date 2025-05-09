using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int pickCount = 0;
    public int putCount = 0;
    public TextMeshProUGUI pickCountText;
    public TextMeshProUGUI putCountText;

    private void Awake()
    {
        // 싱글톤 설정
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void PickItem(GameObject item)
    {
        Destroy(item);
        pickCount++;
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (pickCountText != null)
        {
            pickCountText.text = $"Pick Count: {pickCount}";
        }

        if (putCountText != null)
            putCountText.text = $"Put Count: {putCount}";
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 씬이 로딩될 때 텍스트 다시 찾기
        pickCountText = GameObject.Find("PickCountText")?.GetComponent<TextMeshProUGUI>();
        putCountText = GameObject.Find("PutCountText")?.GetComponent<TextMeshProUGUI>();
        UpdateUI();
    }
}
