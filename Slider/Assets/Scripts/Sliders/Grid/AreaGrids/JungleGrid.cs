using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JungleGrid : SGrid
{
    public static JungleGrid instance;

    private new void Awake() {
        myArea = Area.Jungle;

        foreach (Collectible c in collectibles) 
        {
            c.SetArea(myArea);
        }

        base.Awake();

        instance = this;
    }
    

    void Start()
    {
        foreach (Collectible c in collectibles) 
        {
            if (PlayerInventory.Contains(c)) 
            {
                c.gameObject.SetActive(false);
            }
        }
        
        AudioManager.PlayMusic("Connection");
        UIEffects.FadeFromBlack();
    }

    public override void SaveGrid() 
    {
        base.SaveGrid();
    }

    public override void LoadGrid()
    {
        base.LoadGrid();
    }

    public void RearrangeLinkTile()
    {

        int[,] puzzleArr = new int[3, 3];

        int t1x = -1;
        int t1y = -1;
        bool found = false;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (GetGrid()[x, y].islandId == 1)
                {
                    t1x = x;
                    t1y = y;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                break;
            }
        }
        puzzleArr[t1x, t1y] = 1;
        if (t1y != 2 || t1x == 2)
        {
            puzzleArr[0, 2] = 2;
            puzzleArr[1, 2] = 3;
        } 
        else
        {
            puzzleArr[0, 1] = 2;
            puzzleArr[1, 1] = 3;
        }
        int curElem = 4;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (puzzleArr[x,y] == 0)
                {
                    puzzleArr[x, y] = curElem;
                    curElem++;
                }
            }
        }
        SetGrid(puzzleArr);
    }
}
