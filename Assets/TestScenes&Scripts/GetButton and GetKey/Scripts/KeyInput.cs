using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standart;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
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
        bool down = Input.GetKeyDown(KeyCode.Space);        
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

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
        boolDisplay3.text = " " + up;
    }
}
