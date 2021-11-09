using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicOnOff : MonoBehaviour
{
    bool musicState = false;
    public Button button;
    public Sprite soundOn;
    public Sprite soundOff;
    public void onHit()
    {
        button = GetComponent<Button>();
        if (musicState)
        {
            button.image.sprite = soundOn;
            AudioListener.pause = false;
            musicState = false;
        }
        else
        {
            button.image.sprite = soundOff;
            AudioListener.pause = true;
            musicState = true;
        }
        
    }
    
}
