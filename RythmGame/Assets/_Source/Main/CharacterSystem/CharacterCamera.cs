using UnityEngine;

namespace CharacterSystem
{
    public class CharacterCamera : MonoBehaviour
    {
        [SerializeField] Transform _character;

        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector3(_character.position.x, _character.position.y, -8.236691f);
        }
    }

}
