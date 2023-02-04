using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgSoundSource;

    public AudioClip bgSoundClip;

   public void BgSound(){
       bgSoundSource.PlayOneShot(bgSoundClip);
   }
}
