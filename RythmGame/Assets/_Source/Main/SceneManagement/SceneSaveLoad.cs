using SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSaveLoad : MonoBehaviour
{
    [SerializeField] string sceneName;
    SceneChanger _changer;
    private int currentSceneIndex;
    //private int sceneToContinue;

    private void Awake()
    {
        _changer = new SceneChanger();
    }

    public void SaveScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
    }

    public void LoadScene()
    {
        //sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void ChangeScene()
    {
        _changer.ChangeScene(sceneName);
    }
}
