using UnityEngine.SceneManagement;

namespace SceneManagement
{
    public class SceneChanger
    {
        public void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

