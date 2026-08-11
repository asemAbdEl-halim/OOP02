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

            #region Quetion02
            /*
               * 2) Create Three Shipment Types
               * => Answer <==
               * in the Shipment class, we have three types of shipments: StandardShipment, ExpressShipment, and InternationalShipment.
               * **/ 
            #endregion
            #endregion

            #endregion
        }
    }
}
