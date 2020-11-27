using System;
using System.Linq;
using System.Collections.Generic;

class Billing
{

#region struct
    //Declare Fruit Struct
    struct FruitStruct
    {
        public int ProductId;
        public string ProductName;
        public float ProductPrice;
        public float ProductDiscount;
    }

    //create Bill struct
    struct BillStruct
    {
        //constructors
        public BillStruct(FruitStruct _fruit, int _quantity)
        {
            Fruit = _fruit;
            Quantity = _quantity;
        }
        public FruitStruct Fruit;
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
Dictionary<int, FruitStruct> _fruitDatabase = new Dictionary<int, FruitStruct>();
List<BillStruct> _billList = new List<BillStruct>();
#endregion

    public  void start();
    {
        Console.WriteLine("Billing.Start");
        CreateFruitDatabase();
        ScanAndCreateBill();
        PrintBill();

    }

    void CreateFruitDatabase();
    {
        FruitStruct apples = new FruitStruct();
        
        //create apple instance
        FruitStruct apples = new FruitStruct();
        apples.ProductId = 1456;
        apples.ProductName = "Apples";
        apples.ProductPrice = 1.2f;
        apples.ProductDiscount = 1;
        //create mango instance
        FruitStruct mangos = new FruitStruct();
        mangos.ProductId = 2567;
        mangos.ProductName = "mangos";
        mangos.ProductPrice = 2.2f;
        mangos.ProductDiscount = 1;
        //create watermelons instance
        FruitStruct watermelons = new FruitStruct();
        watermelons.ProductId = 3234;
        watermelons.ProductName = "watermelons";
        watermelons.ProductPrice = 10.5f;
        watermelons.ProductDiscount = 0.9f;
        //create oranges instance
        FruitStruct oranges = new FruitStruct();
        oranges.ProductId = 466;
        oranges.ProductName = "oranges";
        oranges.ProductPrice = 3.5f;
        oranges.ProductDiscount = 1;

        _fruitdatabase.
    }

    








}