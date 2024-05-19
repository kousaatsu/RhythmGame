using UnityEngine;
using SceneManagement;
using Unity.VisualScripting;

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
        if (Input.anyKeyDown)
        {
            _changer.ChangeScene(sceneName);
        }
    }
}
