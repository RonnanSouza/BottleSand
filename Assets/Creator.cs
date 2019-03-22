using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creator : MonoBehaviour
{
    public GameObject Sand;
    private Color ActualColor;

    // Start is called before the first frame update
    void Start()
    {
        ActualColor = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject inst = Instantiate(Sand, new Vector3(mousePositionInWorld.x, mousePositionInWorld.y, 0), Quaternion.identity);
            inst.GetComponent<SpriteRenderer>().color = ActualColor;
        }
    }

    void ChangeColor(Color c)
    {
        ActualColor = c;
    }

    public void ChangeToYellow()
    {
        ChangeColor(Color.yellow);
    }

    public void ChangeToBlue()
    {
        ChangeColor(Color.blue);
    }

    public void ChangeToCyan()
    {
        ChangeColor(Color.cyan);
    }

    public void ChangeToRed()
    {
        ChangeColor(Color.red);
    }
}
