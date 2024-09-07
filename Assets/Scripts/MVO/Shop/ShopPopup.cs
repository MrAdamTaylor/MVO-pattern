using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPopup : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private ProductView _viewPrefab;
    [SerializeField] private Button _hideButton;
}