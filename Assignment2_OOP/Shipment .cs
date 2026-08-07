using System;

namespace Assignment1_OOP
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode { get; init; }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        // Constructor 1
        public Shipment(string trackingCode)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode)
                ? trackingCode : "Unknown";

            description = "Unknown";
            weight = 1;
            deliveryFee = 50;

            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        // Constructor 2
        public Shipment(string trackingCode,
                        string description,
                        double weight,
                        decimal deliveryFee,
                        DeliveryAddress destination)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode)
                ? trackingCode
                : "Unknown";

            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

            Destination = destination;

            // Use properties to validate
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        // Update Delivery Fee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {








                DeliveryFee = newFee;
            }
        }

        // Print Shipment Information
        public void PrintShipment()
        {
            Console.WriteLine("Shipment Information");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
        }
    }
}