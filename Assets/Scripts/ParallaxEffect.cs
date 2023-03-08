using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float length;
    private float startPos;
    private GameObject cam;
    [SerializeField] private float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("CM vcam1");
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (cam.transform.position.x * parallaxEffect);
        float temporary = (cam.transform.position.x * (1 - parallaxEffect));
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if (temporary > startPos + length)
        {
            startPos += length;
        }


       else  if (temporary < startPos - length)
        {
            startPos -= length;
        }

    }
}
