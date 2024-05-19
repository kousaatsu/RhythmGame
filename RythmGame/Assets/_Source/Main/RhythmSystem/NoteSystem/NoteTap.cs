using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTap : MonoBehaviour
{
    [field: SerializeField] KeyCode _key;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && Input.GetKey(_key))
        {
            Destroy(collision.gameObject);
        }
    }
}
