using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingCart : MonoBehaviour
{
    public Text cartText;
    public Text totalText;
    private Dictionary<string, int> cartItems = new Dictionary<string, int>();
    private float totalPrice = 0;

    void Start()
    {
        cartText.text = "";
        totalText.text = "Total: $0.00";
    }

    public void AddToCart(string itemName, float itemPrice)
    {
        if (cartItems.ContainsKey(itemName))
        {
            cartItems[itemName] += 1;
        }
        else
        {
            cartItems[itemName] = 1;
        }
        totalPrice += itemPrice;
        UpdateCartUI();
    }

    public void RemoveFromCart(string itemName, float itemPrice)
    {
        if (cartItems.ContainsKey(itemName))
        {
            cartItems[itemName] -= 1;
            if (cartItems[itemName] == 0)
            {
                cartItems.Remove(itemName);
            }
            totalPrice -= itemPrice;
            UpdateCartUI();
        }
    }

    private void UpdateCartUI()
    {
        cartText.text = "";
        foreach (KeyValuePair<string, int> item in cartItems)
        {
            cartText.text += item.Key + " x " + item.Value + "\n";
        }
        totalText.text = "Total: $" + totalPrice.ToString("F2");
    }
}
