using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CoinScript : MonoBehaviour
{
    public int value;
    AudioSource pickupAudio;
    public UnityEvent<int, Vector2> scorePickUp;
    // Start is called before the first frame update
    void Start()
    {
        pickupAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (pickupAudio) 
            AudioSource.PlayClipAtPoint(pickupAudio.clip, gameObject.transform.position, pickupAudio.volume);
            Destroy(gameObject);
            CharacterEvents.scoreUp(gameObject,value );
            CoinCounterScript.instance.IncreaseCoins(value);
        }
    }
}
