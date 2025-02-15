using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToggleFireParticle : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    public ParticleSystem fireParticle;
    public ParticleSystem extinguishParticle;
    public GameObject pointLight;

    bool isPlaying = true;


    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if(isPlaying)
            {
                fireParticle.Stop();
                pointLight.SetActive(false);
                if (extinguishParticle != null)
                    extinguishParticle.Play();
                isPlaying = false;
            } 
            else
            {
                fireParticle.Play();
                pointLight.SetActive(true);
                isPlaying = true;
            }
        }
    }
}
