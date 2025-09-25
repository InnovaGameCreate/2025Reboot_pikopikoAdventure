using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] itemArray = new GameObject[3];

    void Start()
    {
        for (int i = 0; i < itemArray.Length; i++)
        {
            itemArray[i].SetActive(i < ItemData.itemPoint);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ItemData.itemPoint < 3)
        {
            itemArray[ItemData.itemPoint].SetActive(true);
            ItemData.itemPoint++;
        }
        else if (Input.GetMouseButtonDown(1) && ItemData.itemPoint > 0)
        {
            ItemData.itemPoint--;
            itemArray[ItemData.itemPoint].SetActive(false);
        }
    }
}
