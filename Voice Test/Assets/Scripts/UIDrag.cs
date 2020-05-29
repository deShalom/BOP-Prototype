using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDrag : MonoBehaviour
{
    public void OnDrag() { transform.position = Input.mousePosition; }
}
