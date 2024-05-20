using UnityEngine;

namespace NPCSystem
{
    public class NPC : MonoBehaviour
    {
        [SerializeField] GameObject _dialogBox;
        //[SerializeField] GameObject _eControl;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 3)
            {
                
            }
        }
    }
}