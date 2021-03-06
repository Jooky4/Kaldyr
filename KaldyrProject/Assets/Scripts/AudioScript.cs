using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


// скрипт управления слайдером громкости

public class AudioScript : MonoBehaviour
{   [Tooltip ("Используемый звуковой миксер")]
    [SerializeField]
    private AudioMixer masterMixer;

   
    public void SetSound(float soundLevel)
    {
        masterMixer.SetFloat("mainVol", soundLevel);
    }
}
