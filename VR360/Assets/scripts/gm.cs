using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class GM : MonoBehaviour
{
    public int score;
    public Text uiScore;

    public VideoPlayer play360;
    public VideoPlayer play2D;

    private bool mute;


    public void AddScore()
    {
        score += 10;
        uiScore.text = "分數：" + score;
    }
    public void SwitchMaute()
    {
        mute = !mute;    //靜音相反   
        play360.SetDirectAudioMute(0, mute); //360
        play2D.SetDirectAudioMute(0, !mute); //2D
    }
}
