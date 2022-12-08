using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderInteraction : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textUI;
    [SerializeField] private Slider _slider;

    private void Start() => 
        _slider.onValueChanged.AddListener(PrintSliderValue);

    private void PrintSliderValue(float arg0) => 
        _textUI.text = arg0.ToString();
}
