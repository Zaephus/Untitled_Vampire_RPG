using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager {

    public static Vector3 MousePosition {
        get {
            Vector3 mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return new Vector3(mouseDir.x, mouseDir.y, 0);
        }
    }
}