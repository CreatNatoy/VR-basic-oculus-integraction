using TMPro;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textUI;

    public void OnButton1Clicked() {
        _textUI.text = "Button1 is clicked";
        Debug.Log("Button1 is clicked");
    }

    public void OnButton2Clicked() {
        _textUI.text = "Button2 is clicked";
        Debug.Log("Button2 is clicked");
    }

    public void OnButton3Clicked() {
        _textUI.text = "Button3 is clicked";
        Debug.Log("Button3 is clicked");
    }
}
