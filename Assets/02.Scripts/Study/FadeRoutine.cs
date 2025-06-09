using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel;

    public float fadeTime = 3f;
    private float timer = 0f;
    private float percent = 0f;

    
    IEnumerator Start()
    {
        yield return null;

        while (percent <= 1f)
        {
            timer += Time.deltaTime;
            percent = timer/ fadeTime;

            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, percent);
            yield return null;
        }
    }

  
}
