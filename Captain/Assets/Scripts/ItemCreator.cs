using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour
{
    const float MAX_ITEM_DISPLACEMENT = 5.0f;

    //Produce the item
    public static void produceItem(GameObject pirate, Object itemPrefab)
    {
        //Randomly set a distance from pirate at which item is produced
        float itemDisplacement = Random.Range(-MAX_ITEM_DISPLACEMENT, MAX_ITEM_DISPLACEMENT);
        Vector3 itemDisplacementVec = new Vector3(itemDisplacement, 0, 0);

        //Create item
        var item = (GameObject)Instantiate(itemPrefab, pirate.transform.localPosition + itemDisplacementVec, Quaternion.identity);
    }
}
