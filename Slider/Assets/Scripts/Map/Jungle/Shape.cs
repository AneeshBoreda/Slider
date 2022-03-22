using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour 
{
    public enum ShapeType
    {
        Semicircle,
        Line,
        Triangle,
    }

    public Sprite[] shapeSprites;

    public Sprite GetSprite(ShapeType t) {
        return shapeSprites[(int) t];
    }

    // Start is called before the first frame update
}
