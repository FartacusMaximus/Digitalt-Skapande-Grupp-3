using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    public int Touches;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Touches++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Touches--;
    }
}
