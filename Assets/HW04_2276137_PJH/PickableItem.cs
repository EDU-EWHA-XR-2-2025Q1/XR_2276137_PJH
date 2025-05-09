using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickableItem : MonoBehaviour
{
    public void OnMouseDown()
    {
        GameManager.Instance.PickItem(this.gameObject);
    }
}
