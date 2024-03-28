using UnityEditor;
using UnityEngine;

namespace MVO
{
    [CustomEditor(typeof(UIHelper))]
    public class UIHelperEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            var helper = (UIHelper)target;

            if (GUILayout.Button("Add Money"))
            {
                helper.AddMoney();
            }
            
            if (GUILayout.Button("Spend Money"))
            {
                helper.SpendMoney();
            }
            
            if (GUILayout.Button("Add Gem"))
            {
                helper.AddGem();
            }
            
            if (GUILayout.Button("Spend Gem"))
            {
                helper.SpendGem();
            }
        }
    }
}