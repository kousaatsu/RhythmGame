using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    [SerializeField] GameObject _settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettingsTab()
    {
        Time.timeScale = 0f;
        _settings.SetActive(true);
    }

    public void CloseSettingsTab()
    {
        Time.timeScale = 1.0f;
        _settings.SetActive(false);
    }
}
