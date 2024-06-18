using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOnCollision : MonoBehaviour
{
    [SerializeField] string sceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
