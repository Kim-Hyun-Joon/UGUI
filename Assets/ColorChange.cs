using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColor() {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
    public void ChangeColorToggle(bool isOn) {
        if (isOn) {
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
    public void ChangeColorSlider(float percentage) {
        Color color = new Color(percentage, 0, 0);
        GetComponent<Renderer>().material.color = color;
    }
    public void ChangeColorDropdown(int index) {
        Color color = Color.white;
        switch (index) {
            case 0:
                color = Color.red;
                break;
            case 1:
                color = Color.blue;
                break;
            case 2:
                color = Color.green;
                break;
            case 3:
                color = Color.white;
                break;

        }
        GetComponent<Renderer>().material.color = color;
    }
}
