using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public AudioClip CrashAudio;
    private AudioSource CrashAudioSource;
    public GameObject ObjectsPrefabsR;
    public GameObject ObjectsPrefabsL;
    void Start()
    {
        CrashAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {


        //FirstCollision = true;

        if (collision.gameObject.CompareTag("Small Ball"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            CrashAudioSource.playOnAwake = true;
        }
        if (collision.gameObject.CompareTag("Big Ball"))
        {
            CrashAudioSource.PlayOneShot(CrashAudio, 1.0f);
            Instantiate(ObjectsPrefabsR, new Vector3(transform.position.x, transform.position.y, -1f), ObjectsPrefabsR.transform.rotation);
            Instantiate(ObjectsPrefabsL, new Vector3(transform.position.x, transform.position.y, -1f), ObjectsPrefabsL.transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            //CrashAudioSource.playOnAwake = true;
            
        }
    }
}
