using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    private void OnCollisionEnter2D(Collision other){
        if (!other.gameObject.CompareTag("Player")){
            audioSource.PlayOneShot(audioClip);
            StartCoroutine("Destroy");
        }
    }

    IEnumerator Destroy(){
        yield return new WaitForSeconds(.5f);
        Destroy(this);
    }
}
