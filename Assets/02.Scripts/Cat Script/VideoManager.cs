using UnityEngine;
using UnityEngine.Video;

namespace Cat
{
    public class VideoManager : MonoBehaviour
    {
        public GameObject videoPanel;

        private VideoPlayer vPlayer;
        public VideoClip[] vClips;

        void Start()
        {
            vPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            videoPanel.SetActive(true);

            var clip = isHappy ? vClips[0] : vClips[1];
            vPlayer.clip = clip;
            vPlayer.Play();
        }
    }
}