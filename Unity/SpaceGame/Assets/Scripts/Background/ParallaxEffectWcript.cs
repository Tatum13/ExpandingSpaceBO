using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffectWcript : MonoBehaviour
{
    private float length, height, startposX, startposY;
    public GameObject cam;
    public float parallaxEffectHorizontal;
    public float parallaxEffectVertical;

    // Start is called before the first frame update
    void Start()
    {
        startposX = transform.position.x;
        startposY = transform.position.y;

        length = GetComponent<SpriteRenderer>().bounds.size.x;
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        float tempX = (cam.transform.position.x * (1 - parallaxEffectHorizontal));
        float distX = (cam.transform.position.x * parallaxEffectHorizontal);
        
        float tempY = (cam.transform.position.y * (1 - parallaxEffectVertical));
        float distY = (cam.transform.position.y * parallaxEffectVertical);

        transform.position = new Vector3(startposX + distX, startposY + distY, transform.position.z);

        if (tempX > startposX + length)
        {
            startposX += length * 2;
        }
        else if (tempX < startposX - length)
        {
            startposX -= length * 2;
        }

        if (tempY > startposY + height)
        {
            startposY += height * 2;
        }
        else if (tempY < startposY - height)
        {
            startposY -= height * 2;
        }
    }
}
