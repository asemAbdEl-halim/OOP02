namespace Session2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Quetion01
            /*
             *1- a) What is the difference between a class and a struct?
             * ==> Answer <==
             * A class is a reference type, while a struct is a value type.
             * A class is stored as an object, and a struct is copied when we assign it to another variable.
             * Classes can have more complex behavior, while structs are usually used for small amounts of data.
             * 
             * 1- b) Why are classes more suitable than structs for large applications?
                * ==> Answer <==
                * Classes are better for large applications because they support inheritance, encapsulation, and polymorphism.
                * They also make it easier to manage and share objects in large programs.
             ***/
            #endregion

            #region Quetion02

            /*
             *  a) Which class is the parent class?
                * ==> Answer <==
                * Shipment is the parent class.
                * 
             *  b) Which class is the child class?
                * ==> Answer <==
                * ExpressShipment is the child class.
                * 
             *  c) What members are inherited by ExpressShipment?
                * ==> Answer <==
                * ExpressShipment inherits the TrackingCode property from Shipment.
                * 
             *  d) Why is inheritance better than duplicating the same code in multiple classes?
                *  => Answer <==
                *  Inheritance helps us reuse code and avoids writing the same code again. It also makes the program easier to maintain and update.
             * **/

            #endregion

            #endregion

            #region Part02

            #region Quetion01
            /*
             * 1) Shipment Class
             * => Answer <==
             * in the Shipment class, we have two constructors. The first constructor takes only a tracking code and sets default values for the other properties. 
             * The second constructor takes all the properties as parameters and initializes them.
             * **/

            #endregion

            #region Quetion02
            /*
               * 2) Create Three Shipment Types
               * => Answer <==
               * in the Shipment class, we have three types of shipments: StandardShipment, ExpressShipment, and InternationalShipment.
               * **/
            #endregion

            #region Quetion03

            /*
             * 3) DeliveryCenter Class
             * => Answer <==
             * in the DeliveryCenter class, we have an array of Shipment objects to store the shipments. We also have two indexers: one for accessing shipments by index and another for accessing shipments by tracking code. 
             * The AddShipment method allows us to add a new shipment to the array.
             * **/

            #endregion

            #region Quetion04

            /*
             * 4- Demonstrate Class Relationships
             * => Answer <==
             * in the shipment classes , we have a 3 relationships between the classes. The Shipment class is the base class,
             * and the StandardShipment, ExpressShipment, and InternationalShipment classes are derived from it.
             * **/

            #endregion

            #region Quetion05
            //    // 1. Create DeliveryCenter
            //    DeliveryCenter center = new DeliveryCenter();

            //    // 2. Read Center Name
            //    Console.Write("Enter Center Name: ");
            //    center.CenterName = Console.ReadLine();

            //    Console.WriteLine();


            //    // =========================
            //    // Standard Shipment
            //    // =========================

            //    Console.WriteLine("Enter Standard Shipment Data");

            //    Console.Write("Tracking Code: ");
            //    string standardCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string standardDescription = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    decimal standardWeight = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal standardFee = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("City: ");
            //    string standardCity = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string standardStreet = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int standardBuilding = Convert.ToInt32(Console.ReadLine());

            //    DeliveryAddress standardAddress =
            //        new DeliveryAddress(
            //            standardCity,
            //            standardStreet,
            //            standardBuilding);

            //    StandardShipment standardShipment =
            //        new StandardShipment(
            //            standardCode,
            //            standardDescription,
            //            standardWeight,
            //            standardFee,
            //            standardAddress);

            //    center.AddShipment(standardShipment);

            //    Console.WriteLine("Shipment added successfully.");
            //    Console.WriteLine();


            //    // =========================
            //    // Express Shipment
            //    // =========================

            //    Console.WriteLine("Enter Express Shipment Data");

            //    Console.Write("Tracking Code: ");
            //    string expressCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string expressDescription = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    decimal expressWeight = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal expressFee = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("Extra Fee: ");
            //    decimal extraFee = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("City: ");
            //    string expressCity = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string expressStreet = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int expressBuilding = Convert.ToInt32(Console.ReadLine());

            //    DeliveryAddress expressAddress =
            //        new DeliveryAddress(
            //            expressCity,
            //            expressStreet,
            //            expressBuilding);

            //    ExpressShipment expressShipment =
            //        new ExpressShipment(
            //            expressCode,
            //            expressDescription,
            //            expressWeight,
            //            expressFee,
            //            expressAddress,
            //            extraFee);

            //    center.AddShipment(expressShipment);

            //    Console.WriteLine("Shipment added successfully.");
            //    Console.WriteLine();


            //    // =========================
            //    // International Shipment
            //    // =========================

            //    Console.WriteLine("Enter International Shipment Data");

            //    Console.Write("Tracking Code: ");
            //    string internationalCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string internationalDescription = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    decimal internationalWeight = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal internationalFee = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("Destination Country: ");
            //    string country = Console.ReadLine();

            //    Console.Write("Customs Fee: ");
            //    decimal customsFee = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("City: ");
            //    string internationalCity = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string internationalStreet = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int internationalBuilding = Convert.ToInt32(Console.ReadLine());

            //    DeliveryAddress internationalAddress =
            //        new DeliveryAddress(
            //            internationalCity,
            //            internationalStreet,
            //            internationalBuilding);

            //    InternationalShipment internationalShipment =
            //        new InternationalShipment(
            //            internationalCode,
            //            internationalDescription,
            //            internationalWeight,
            //            internationalFee,
            //            internationalAddress,
            //            country,
            //            customsFee);

            //    center.AddShipment(internationalShipment);

            //    Console.WriteLine("Shipment added successfully.");
            //    Console.WriteLine();


            //    // 8. Print all shipments
            //    Console.WriteLine("========== All Shipments ==========");
            //    center.PrintAllShipments();


            //    // 9. Search for a shipment
            //    Console.WriteLine();
            //    Console.Write("Enter Tracking Code to Search: ");
            //    string searchCode = Console.ReadLine();

            //    Shipment foundShipment = center[searchCode];

            //    if (foundShipment != null)
            //    {
            //        Console.WriteLine("Shipment Found:");
            //        foundShipment.PrintShipment();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Shipment not found.");
            //    }


            //    // 10. Remove shipment
            //    Console.WriteLine();
            //    Console.Write("Enter Tracking Code to Remove: ");
            //    string removeCode = Console.ReadLine();

            //    bool removed = center.RemoveShipment(removeCode);

            //    if (removed)
            //    {
            //        Console.WriteLine("Shipment Removed Successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Shipment not found.");
            //    }


            //    // 11. Print remaining shipments
            //    Console.WriteLine();
            //    Console.WriteLine("========== Remaining Shipments ==========");
            //    center.PrintAllShipments();
            //}
            #endregion

            #endregion

        }
    }
}
