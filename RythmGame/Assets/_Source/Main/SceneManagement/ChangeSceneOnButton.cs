using UnityEngine;
using SceneManagement;

public class ChangeSceneOnButton : MonoBehaviour
{
    [SerializeField] string sceneName;
    SceneChanger _changer;

    private void Awake()
    {
        _changer = new SceneChanger();
    }
    private void Update()
    {
        if (Input.anyKey)
        {
            _changer.ChangeScene(sceneName);
        }
    }
}
