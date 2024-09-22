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
        
        if (GUILayout.Button("BuyProduct"))
        {
            lessonHelper.BuyProduct();
        }
    }
}