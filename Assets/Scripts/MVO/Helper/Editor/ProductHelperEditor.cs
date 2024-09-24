using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ProductHelper))]
public class ProductHelperEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        var lessonHelper = (ProductHelper) target;

        if (GUILayout.Button("Show Popup Product"))
        {
            lessonHelper.ShowProductPopup();
        }
        
        if (GUILayout.Button("Hide Popup Product"))
        {
            lessonHelper.HideProductPopup();
        }
    }
}
