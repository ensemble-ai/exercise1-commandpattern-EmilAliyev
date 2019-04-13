using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour
{
    //Produce the item
    public static void produceItem(GameObject pirate, Object itemPrefab)
    {
        //Create item
        var item = (GameObject)Instantiate(itemPrefab, pirate.transform.localPosition, Quaternion.identity);
    }
}
