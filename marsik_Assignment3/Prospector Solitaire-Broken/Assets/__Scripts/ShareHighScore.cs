using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShareHighScore : ScoreManager
{
    private string _URL = "https://twitter.com/intent/tweet";
    private string _language = "en";
    private string _param = " ";
    private string _display = ("score" + SCORE);
    public Button shareButton;

    // Start is called before the first frame update
    void Start()
    {
        Button mediaButton = shareButton.GetComponent<Button>();
        mediaButton.onClick.AddListener(OnClickTask);

    }

    void OnClickTask()
    {
        Application.OpenURL(_URL + "?text= My high score is: " + HIGH_SCORE + "&amp;lang=" + UnityWebRequest.EscapeURL(_language));
    }
}
