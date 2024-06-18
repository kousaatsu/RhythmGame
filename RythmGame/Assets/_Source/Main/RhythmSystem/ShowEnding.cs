using UnityEngine;

public class ShowEnding : MonoBehaviour
{
    [SerializeField] AudioSource _as;
    [SerializeField] GameObject _ending;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_as.isPlaying)
        {
            _ending.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
