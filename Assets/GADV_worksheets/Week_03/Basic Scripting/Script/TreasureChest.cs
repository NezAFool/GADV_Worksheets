using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest
{
    public virtual void Unlock(bool hasToken) 
    {
        Debug.Log("Not Overridden");
    }
    public virtual void Unlock()
    {
        Debug.Log("Not Overridden");
    }
    public void shake()
    {
        Debug.Log("You hear something rattle inside the chest.");

    }
    bool Token = false;
}
public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You unlock the ancient chest with an ancient key.");
    }
    public override void Unlock(bool hasToken)
    {
        if (hasToken == true)
        {
            Debug.Log("Bonus Loot");
        }
        else
        {
            Debug.Log("Normal Open");
        }
    }
}
public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You cast a spell to unlock the magic chest.");
    }
    public override void Unlock(bool hasToken)
    {
        if (hasToken == true)
        {
            Debug.Log("Bonus Loot");
        }
        else
        {
            Debug.Log("Normal Open");
        }
    }
}
