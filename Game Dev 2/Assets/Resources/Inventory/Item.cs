﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public GameObject prefab;

    public void PickupObject()
    {
        for (int i = 0; i < Inventory.Instance.slots.Length; i++)
        {
            if (Inventory.Instance.currentInventoryItems[i] == null)
            {
                Inventory.Instance.currentInventoryItems[i] = this.gameObject;
                Inventory.Instance.slots[i].GetComponent<Slot>().myImageObject.SetActive(true);
                Inventory.Instance.UpdateSlotUI();
                gameObject.SetActive(false);
                break;
            }
        }
    }
}
