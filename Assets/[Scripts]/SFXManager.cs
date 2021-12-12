using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource audioSource;
    public void OnButtonClick()
    {
        audioSource.Play();
    }
}
