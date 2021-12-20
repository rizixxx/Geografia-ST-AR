using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisableChapter : MonoBehaviour
{
    public Button button;
    public void disablebutton()
    {
        button.interactable = false;
    }
}
