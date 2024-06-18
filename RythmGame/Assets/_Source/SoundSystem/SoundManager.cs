using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundSystem
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource SFXSource;
        public GameObject notes;
        private void Start()
        {
            StartCoroutine(CoroutineTimer());
        }
        public void PlaySound(AudioClip sound)
        {
            SFXSource.PlayOneShot(sound);
        }

        IEnumerator CoroutineTimer()
        {
            yield return new WaitForSeconds(0.8f);
            notes.SetActive(true);
        }

    }

}
