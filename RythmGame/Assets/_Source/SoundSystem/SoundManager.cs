using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundSystem
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource SFXSource;
        public void PlaySound(AudioClip sound)
        {
            SFXSource.PlayOneShot(sound);
        }
    }

}
