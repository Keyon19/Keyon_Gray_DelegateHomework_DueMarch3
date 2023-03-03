using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class eventHandler : MonoBehaviour
{
    public GameObject g;
    // Event Handler
    public delegate void OnClickEvent(GameObject g);
    public event OnClickEvent OnClick;
    public void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            OnClick(hits[i].collider.gameObject);
            Debug.Log(hits[i].collider.gameObject);
        } 
    }
}
