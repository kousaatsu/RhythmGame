using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AMVolume : MonoBehaviour
{
    string prefName;
    [SerializeField] private AudioMixer AM;
    [SerializeField] private string group;
    [SerializeField] public Slider volumeSlider;
    void Start()
    {
        if (PlayerPrefs.HasKey(prefName))
        {
            volumeSlider.value = PlayerPrefs.GetFloat(prefName);
        }
    }

    public void SetVolume(float sliderValue)
    {
        AM.SetFloat(group, Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat(prefName, sliderValue);
    }
}
