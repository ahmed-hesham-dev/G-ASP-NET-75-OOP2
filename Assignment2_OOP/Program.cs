namespace Assignment2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions1


            // a) Difference between a class and a struct:
            // A class is a reference type, while a struct is a value type.
            // Classes are stored by reference, while structs are stored by value.
            // Classes can support 4pealers, but structs support only incapsolation.
            // Classes are usually used for complex objects, while structs are suitable for small data types.

            // b) Why are classes more suitable than structs for large applications?
            // Classes are more suitable for large applications because they support inheritance,
            // polymorphism, encapsulation, and reference sharing.
            // They are better for representing complex objects and managing large amounts of data and behavior.

            #endregion


            #region Theoretical Questions2


            // a) Which class is the parent class?
            // Answer: Shipment 

            // b) Which class is the child class?
            // Answer: ExpressShipment 

            // c) What members are inherited by ExpressShipment?
            // Answer: ExpressShipment inherits the TrackingCode property from Shipment.

            // d) Why is inheritance better than duplicating the same code in multiple classes?
            // Answer: Inheritance avoids code duplication, improves code reuse,
            // and makes the program easier to maintain and modify.

            #endregion


            #region Practical Questions1
            #endregion

            #region Practical Questions2
            #endregion
            #region Practical Questions3
            #endregion
            #region Practical Questions4
            // Done
            //            ///Inheritance
            //            Shipment
            //├── StandardShipment
            //├── ExpressShipment
            //└── InternationalShipment

            #endregion

            #region Practical Questions5

            // Read Delivery Center name
            Console.Write("Enter Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center = new DeliveryCenter(centerName);

            // =========================
            // Standard Shipment
            // =========================

            Console.WriteLine("\n--- Standard Shipment ---");

            Console.Write("Tracking Code: ");
            string standardTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string standardDescription = Console.ReadLine();

            Console.Write("Weight: ");
            double standardWeight = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal standardDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string standardCity = Console.ReadLine();

            Console.Write("Street: ");
            string standardStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int standardBuildingNumber = int.Parse(Console.ReadLine());

            DeliveryAddress standardAddress =
                new DeliveryAddress(
                    standardCity,
                    standardStreet,
                    standardBuildingNumber
                );

            StandardShipment standardShipment =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardDeliveryFee,
                    standardAddress
                );

            // =========================
            // Express Shipment
            // =========================

            Console.WriteLine("\n--- Express Shipment ---");

            Console.Write("Tracking Code: ");
            string expressTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string expressDescription = Console.ReadLine();

            Console.Write("Weight: ");
            double expressWeight = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal expressDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string expressCity = Console.ReadLine();

            Console.Write("Street: ");
            string expressStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int expressBuildingNumber = int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress expressAddress =
                new DeliveryAddress(
                    expressCity,
                    expressStreet,
                    expressBuildingNumber
                );

            ExpressShipment expressShipment =
                new ExpressShipment(
                    expressTrackingCode,
                    expressDescription,
                    expressWeight,
                    expressDeliveryFee,
                    expressAddress,
                    extraFee
                );

            // =========================
            // International Shipment
            // =========================

            Console.WriteLine("\n--- International Shipment ---");

            Console.Write("Tracking Code: ");
            string internationalTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string internationalDescription = Console.ReadLine();

            Console.Write("Weight: ");
            double internationalWeight = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string internationalCity = Console.ReadLine();

            Console.Write("Street: ");
            string internationalStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int internationalBuildingNumber = int.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress internationalAddress =
                new DeliveryAddress(
                    internationalCity,
                    internationalStreet,
                    internationalBuildingNumber
                );

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    internationalTrackingCode,
                    internationalDescription,
                    internationalWeight,
                    internationalDeliveryFee,
                    internationalAddress,
                    destinationCountry,
                    customsFee
                );

            // =========================
            // Add Shipments
            // =========================

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            // =========================
            // Print All Shipments
            // =========================

            Console.WriteLine("\n===== All Shipments =====");
            center.PrintAllShipments();

            // =========================
            // Search Shipment
            // =========================

            Console.Write("\nEnter Tracking Code to search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine("\n===== Shipment Found =====");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // =========================
            // Remove Shipment
            // =========================

            Console.Write("\nEnter Tracking Code to remove: ");
            string removeCode = Console.ReadLine();

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // =========================
            // Print Remaining Shipments
            // =========================

            Console.WriteLine("\n===== Remaining Shipments =====");
            center.PrintAllShipments();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            #endregion

        }
    }
}
