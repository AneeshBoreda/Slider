using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Shape;

public class ShapeCreatorScript : MonoBehaviour
{
    public Vector2[] validDirs; 
    public int currentDir = 0;

    public ShapeType[] producedShapes = new ShapeType[] {ShapeType.Semicircle, ShapeType.Line, ShapeType.Triangle};
    public int currentShape = 0;

    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate() {
        currentDir = (currentDir + 1) % validDirs.Length;
        Debug.Log(currentDir+"");
    }
    public void ChangeShape() {
        currentShape = (currentShape + 1) % producedShapes.Length;
        Debug.Log(currentShape+"");
    }
}
