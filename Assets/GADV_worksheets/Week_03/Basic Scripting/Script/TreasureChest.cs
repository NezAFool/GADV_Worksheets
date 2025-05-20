using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest
{
    public void shake()
    {
        Debug.Log("You hear something rattle inside the chest.");
    }
    
public class AcientChest : TreasureChest
    {
        
    }
    public class MagicChest : TreasureChest
    {

    }
}