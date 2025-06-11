using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;

    public VideoClip[] clips; // 영상 파일 배열

    private VideoPlayer videoPlayer;

    public int currClipIndex = 0;
    // public bool isOn = false;
    public bool isMute = false;

    void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0];
    }

    void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnNextChannel);
        buttonUI[3].onClick.AddListener(OnPrevChannel);
    }

    public void OnScreenPower()
    {
        // GameObject 속성을 활용한 방법
        videoScreen.SetActive(!videoScreen.activeSelf);

        // NOT을 활용하여 줄여서 적은 방법
        // isOn = !isOn;
        // videoScreen.SetActive(isOn);

        // 길게 적은 방법
        // if (!isOn) // isOn == false
        // {
        //     videoScreen.SetActive(true);
        //     isOn = true; // 현재 티비 On
        // }
        // else // isOn == true
        // {
        //     videoScreen.SetActive(false);
        //     isOn = false;
        // }
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute); // 영상의 소리 음소거

        // 현재 영상의 Mute 속성을 활용한 방법
        // videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0));
    }
    public void OnNextChannel()
    {
        currClipIndex++;
        currClipIndex = currClipIndex % clips.Length;
        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }
    public void OnPrevChannel()
    {
        currClipIndex--;
        if(currClipIndex < 0) {
            currClipIndex = clips.Length-1;
        }
        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }
}