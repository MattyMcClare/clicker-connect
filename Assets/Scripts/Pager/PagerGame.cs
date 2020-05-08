using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagerGame : MonoBehaviour
{
    [SerializeField] int counter = 0;
    [SerializeField] double price = 100d;
    [SerializeField] float allCps = 20f;
    [SerializeField] float oneCps = 20f;
    [SerializeField] int percentIndex = 2;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void AddToConnectionCounter(){
        counter++;
    }

    public void AddToAllCps(){
        allCps += oneCps;
    }

    public void IncreasePrice(){
        AddToConnectionCounter();
        AddToAllCps();
        double percentage = percentIndex * 0.01;

        double priceCalculation = price + price * percentage;

        price = Mathf.Round((float)priceCalculation);
    }

    public int GetCounter(){
        return counter;
    }

    public double GetPrice(){
        return price;
    }

    public float GetAllCps(){
        return allCps;
    }

    public float GetOneCps(){
        return oneCps;
    }

}
