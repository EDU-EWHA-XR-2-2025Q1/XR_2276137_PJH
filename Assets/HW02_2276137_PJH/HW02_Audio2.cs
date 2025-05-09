using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource[] Audio;

    void Start()
    {
           Audio[0].loop = true;
           Audio[0].Play();

    }

    void Update()
    {
        // 엔터 키 누르면 모든 오디오 토글
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Audio[0].Pause();
        }
    }
}
