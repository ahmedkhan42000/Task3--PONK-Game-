using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip FireAudioClip;
 
    private AudioSource FireAudioSource;
    public float HorizontalInput;
    private float Speed = 5;
    private float PlayerMovementrange = 8;
    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        FireAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -PlayerMovementrange)
        {
            transform.position = new Vector3(-PlayerMovementrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > PlayerMovementrange)
        {
            transform.position = new Vector3(PlayerMovementrange, transform.position.y, transform.position.z);
        }
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * Speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, transform.position + new Vector3(0,2,0), ProjectilePrefab.transform.rotation);
            FireAudioSource.PlayOneShot(FireAudioClip, 1.0f);
        }
    
    
    }
       

    }
