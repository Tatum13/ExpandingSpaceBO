using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchActiveChairScript : MonoBehaviour
{

    public Sprite chairLeftActive;
    public Sprite chairLeftBusy;
    public Sprite chairMidActive;
    public Sprite chairMidBusy;
    public Sprite chairRightActive;
    public Sprite chairRightBusy;
    private SpriteRenderer[] spriteRenderer;
    private SpriteRenderer leftChairSprite;
    private SpriteRenderer midChairSprite;
    private SpriteRenderer rightChairSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponentsInChildren<SpriteRenderer>();
        leftChairSprite = spriteRenderer[0];
        midChairSprite = spriteRenderer[1];
        rightChairSprite = spriteRenderer[2];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            leftChairSprite.sprite = chairLeftActive;
            midChairSprite.sprite = chairMidBusy;
            rightChairSprite.sprite = chairRightBusy;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            leftChairSprite.sprite = chairLeftBusy;
            midChairSprite.sprite = chairMidActive;
            rightChairSprite.sprite = chairRightBusy;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            leftChairSprite.sprite = chairLeftBusy;
            midChairSprite.sprite = chairMidBusy;
            rightChairSprite.sprite = chairRightActive;
        }
    }
}
