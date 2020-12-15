using System;
using System.Linq;
using System.Collections.Generic;

class Billing
{

#region struct
    //Declare Fruit Struct
    struct C_FruitStruct
    {
        public int ProductId;
        public string ProductName;
        public float ProductPrice;
        public float ProductDiscount;
    }

    //create Bill struct
    struct C_BillStruct
    {
        //constructors
        public C_BillStruct(C_FruitStruct _fruit, int _quantity)
        {
            Fruit = _fruit;
            Quantity = _quantity;
        }
        public C_FruitStruct Fruit;
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

#region class varaiables
Dictionary<int, C_FruitStruct> C_fruitDatabase = new Dictionary<int, C_FruitStruct>();
 List<C_BillStruct> C_billList = new List<C_BillStruct>();
#endregion

    public void C_Bill()
    {
        Console.WriteLine("Billing.Start");
        C_CreateFruitDatabase();
        C_ScanAndCreateBill();
        C_PrintBill();

    }

    void C_CreateFruitDatabase()
    {
            
        //create apple instance
        C_FruitStruct L_apples = new C_FruitStruct();
        L_apples.ProductId = 1456;
        L_apples.ProductName = "Apples";
        L_apples.ProductPrice = 1.2f;
        L_apples.ProductDiscount = 1;
        //create mango instance
        C_FruitStruct L_mangos = new C_FruitStruct();
        L_mangos.ProductId = 2567;
        L_mangos.ProductName = "mangos";
        L_mangos.ProductPrice = 2.2f;
        L_mangos.ProductDiscount = 1;
        //create watermelons instance
        C_FruitStruct L_watermelons = new C_FruitStruct();
        L_watermelons.ProductId = 3234;
        L_watermelons.ProductName = "watermelons";
        L_watermelons.ProductPrice = 10.5f;
        L_watermelons.ProductDiscount = 0.9f;
        //create oranges instance
        C_FruitStruct L_oranges = new C_FruitStruct();
        L_oranges.ProductId = 466;
        L_oranges.ProductName = "oranges";
        L_oranges.ProductPrice = 3.5f;
        L_oranges.ProductDiscount = 1;

        C_fruitDatabase.Add(L_apples.ProductId, L_apples);
        C_fruitDatabase.Add(L_mangos.ProductId,L_mangos);
        C_fruitDatabase.Add(L_oranges.ProductId,L_oranges);
        C_fruitDatabase.Add(L_watermelons.ProductId,L_watermelons);

    }
    bool C_CheckForCode(int P_produceID)
    {
       if(C_fruitDatabase.ContainsKey(P_produceID))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Product ID " + P_produceID + " is not availabe in the database");
            return false;
        }
    }
    

    void  C_ScanAndCreateBill()
    {
        int L_scanneditem = 123;
        if(C_CheckForCode(L_scanneditem))
        {
            C_billList.Add(new C_BillStruct(C_fruitDatabase[L_scanneditem], 4));
        }
        L_scanneditem = 345;
        if(C_CheckForCode(L_scanneditem))
        {
            C_billList.Add(new C_BillStruct(C_fruitDatabase[L_scanneditem], 2));
        }
        L_scanneditem = 466;
        if(C_CheckForCode(L_scanneditem))
        {
            C_billList.Add(new C_BillStruct(C_fruitDatabase[L_scanneditem], 6));
        }
    }

    public void C_PrintBill()
    {
        Console.WriteLine("purchased items " + C_billList.Count);
        int count = 0;
        foreach (var billStruct in C_billList)
        {
            count++;
            Console.WriteLine(count + " " + billStruct.Fruit.ProductId + " | " + billStruct.Fruit.ProductName + " | " + billStruct.Quantity + " | " + billStruct.Fruit.ProductPrice + "₹ | " + billStruct.GetBillPrice() +"₹" );
        }
    }

}