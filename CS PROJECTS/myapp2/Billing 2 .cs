using System;
using System.Linq;
using System.Collections.Generic;

/*
1  Declare C_FruitStruct
2  Declare C_BillStruct
3  Class Variables
4  C_Billing[program.cs]
5  C_CreateFruitDatabase




*/
class BillingRewind
{

#region structs

    // Declare C_FruitStruct
    struct C_FruitStruct2
    {
        public int ProductId;

        public int ProductName;

        public int ProductPrice;

        public int ProductDiscount;

    }

    // Declare C_BillStruct
    struct C_BillStruct2
    {
        public C_BillStruct2(C_FruitStruct2 _fruit , int _quantity)
        {
            Fruit = _fruit;
            Quantity = _quantity;
        }
        
        public C_FruitStruct2 Fruit;
        public int Quantity;

        public float GetBillPrice()
        {
            return Fruit.ProductPrice * Quantity;
        }

        public float GetBillDiscountPrice()
        {
            return (Fruit.ProductPrice * Fruit.ProductDiscount) * Quantity;
        }

    }

#endregion

#region  Class Variables

Dictionary<int, C_FruitStruct2> C_fruitdatabase = new Dictionary<int, C_FruitStruct2>();

List<C_BillStruct2> C_billlist2 = new  List<C_BillStruct2>();

#endregion

    public void C_billing2()
    {
        Console.WriteLine("Billing Start");
        C_CreateFruitDatabase2();
        C_ScanAndCreateBill2();
        C_PrintBill2();

    }

     void C_CreateFruitDatabase2()
    {
        C_FruitStruct2 L_apples = new C_FruitStruct2();
        L_apples.ProductId = 098;
        L_apples.ProductName = "apples";
        L_apples.ProductPrice = 21;
        L_apples.ProductDiscount = 2;
        //create mango instance
        C_FruitStruct2 L_mangos = new C_FruitStruct2();
        L_mangos.ProductId = 472;
        L_mangos.ProductName = "mangos";
        L_mangos.ProductPrice = 20;
        L_mangos.ProductDiscount = 1;
        //create watermelons instance
        C_FruitStruct2 L_watermelons = new C_FruitStruct2();
        L_watermelons.ProductId = 387;
        L_watermelons.ProductName = "watermelons";
        L_watermelons.ProductPrice = 15;
        L_watermelons.ProductDiscount = 1;
        //create oranges instance
        C_FruitStruct2 L_oranges = new C_FruitStruct2();
        L_oranges.ProductId = 136;
        L_oranges.ProductName = "oranges";
        L_oranges.ProductPrice = 35;
        L_oranges.ProductDiscount = 1;

        C_fruitdatabase.Add(L_apples.ProductId,L_apples);
        C_fruitdatabase.Add(L_mangos.ProductId,L_mangos);
        C_fruitdatabase.Add(L_oranges.ProductId,L_oranges);
        C_fruitdatabase.Add(L_watermelons.ProductId,L_watermelons);

    }
    
    bool C_CheckForCode2(int P_ProductId)
    {
        if(C_fruitdatabase.ContainsKey(P_ProductId))
        {
            return true;
        }

        else
        {
            Console.WriteLine("ProductId" + P_ProductId + "is not availabe");
            return false;
        }
    }

    void C_ScanAndCreateBill2()
    {
        int L_scanneditem = 098;
        if(C_CheckForCode2(L_scanneditem))
        {
            C_billlist2.Add(new C_BillStruct2(C_fruitdatabase[L_scanneditem] , 3));
        }

        L_scanneditem = 472;
        if(C_CheckForCode2(L_scanneditem))
        {
            C_billlist2.Add(new C_BillStruct2(C_fruitdatabase[L_scanneditem] , 6));
        }

        L_scanneditem = 387;
        if(C_CheckForCode2(L_scanneditem))
        {
            C_billlist2.Add(new C_BillStruct2(C_fruitdatabase[L_scanneditem] , 9));
        }

    }

    public void C_PrintBill2()
    {
        Console.WriteLine("Items Purchased" + C_billlist2.Count); 
        int count = 0;
        foreach (var billStruct in C_billlist2)
        {
            count++;
            Console.WriteLine(count + " " + billStruct.Fruit.ProductId + " | " + billStruct.Fruit.ProductName + " | " + billStruct.Quantity + " | " + billStruct.Fruit.ProductPrice + "₹ | " + billStruct.GetBillPrice() +"₹");
        }
    }








}