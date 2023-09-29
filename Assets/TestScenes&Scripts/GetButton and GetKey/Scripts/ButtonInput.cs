using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standart;
    public Sprite downgfx;
    public Sprite heldgfx;
    public Sprite upgfx;
    public TextMeshProUGUI boolDisplay1;
    public TextMeshProUGUI boolDisplay2;
    public TextMeshProUGUI boolDisplay3;

    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standart;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up) 
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standart;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}
