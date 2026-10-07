using DeliverySystem.SmartDeliveryManagementSystem;

namespace OOP_4;

internal class Program
{
    static void Main(string[] args)
    {
        #region Theoretical Questions

        //a)  What is Abstraction in Object-Oriented Programming?
        // Abstraction is the process of hiding implementation details and showing only the essential features of an object

        //b)  Why is abstraction considered one of the four pillars of OOP?
        // Abstraction is one of the four pillars of OOP because it hides unnecessary implementation details and exposes only the essential features, making the code simpler, easier to use

        #endregion

        #region Main() Checklist

        #region creat DeliveryCenter
        // Create a DeliveryCenter object with a driver name.
        Console.WriteLine("Enter Driver Name: ");
        string driverName = Console.ReadLine()!;

        // Create a DeliveryCenter object with the driver name.
        DeliveryCenter deliveryCenter = new DeliveryCenter(driverName);
        #endregion

        #region Creat StanderdShipment
        bool flag = false;

        //Read the tracking code from the user.
        Console.Write("Tracking Code: ");
        string trackingCode = Console.ReadLine();

        //Read the description from the user.
        Console.Write("Description: ");
        string description = Console.ReadLine();

        // Get weight from user
        decimal weight;
        do
        {
            Console.Write("Enter Valid Weight: ");
            flag = decimal.TryParse(Console.ReadLine(), out weight);
        }
        while (!flag || weight <= 0);

        // Get DeliveryFee from user
        decimal deliveryFee;
        do
        {
            Console.Write("Enter Valid Delivery Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out deliveryFee);
        }
        while (!flag || deliveryFee <= 0);

        //Create one StandardShipment.
        StandardShipment standardShipment = new StandardShipment(
            trackingCode,
            description,
            weight,
            deliveryFee
            );

        Console.WriteLine();

        // Add StandardShipment
        if (deliveryCenter.AddShipment(standardShipment))
        {
            Console.WriteLine("Shipment Add Successfully ");

        }
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        #endregion

        #region Creat ExpressShipment

        //Read the tracking code from the user.
        Console.Write("Tracking Code: ");
        string ExpressTrackingCode = Console.ReadLine();

        //Read the description from the user.
        Console.Write("Description: ");
        string ExpressDescription = Console.ReadLine();

        // Get weight from user
        decimal ExpressWeight;
        do
        {
            Console.Write("Enter Valid Weight: ");
            flag = decimal.TryParse(Console.ReadLine(), out ExpressWeight);
        }
        while (!flag || ExpressWeight <= 0);

        // Get DeliveryFee from user
        decimal ExpressDeliveryFee;
        do
        {
            Console.Write("Enter Valid Delivery Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out ExpressDeliveryFee);
        }
        while (!flag || ExpressDeliveryFee <= 0);

        // Get extraFee from user
        decimal ExpressExtraFee;
        do
        {
            Console.Write("Enter Valid Extra Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out ExpressExtraFee);
        }
        while (!flag || ExpressExtraFee < 0);


        //Create one ExpressShipment.
        ExpressShipment expressShipment = new ExpressShipment(
            ExpressTrackingCode,
            ExpressDescription,
            ExpressWeight,
            ExpressDeliveryFee,
            ExpressExtraFee
            );

        Console.WriteLine();

        // Add ExpressShipment
        if (deliveryCenter.AddShipment(expressShipment))
        {
            Console.WriteLine("Shipment Add Successfully ");

        }
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        #endregion

        #region Creat InternationlShipment

        //Read the tracking code from the user.
        Console.Write("Tracking Code: ");
        string InternationlTrackingCode = Console.ReadLine();

        //Read the description from the user.
        Console.Write("Description: ");
        string InternationlDescription = Console.ReadLine();

        // Get weight from user
        decimal InternationlWeight;
        do
        {
            Console.Write("Enter Valid Weight: ");
            flag = decimal.TryParse(Console.ReadLine(), out InternationlWeight);
        }
        while (!flag || InternationlWeight <= 0);

        // Get DeliveryFee from user
        decimal InternationlDeliveryFee;
        do
        {
            Console.Write("Enter Valid Delivery Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out InternationlDeliveryFee);
        }
        while (!flag || InternationlDeliveryFee <= 0);

        // Get customsFee from user
        decimal customsFee;
        do
        {
            Console.Write("Enter Valid customs Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out customsFee);
        }
        while (!flag || customsFee < 0);

        //Read destinationCountry from user
        Console.Write("Destination Country: ");
        string destinationCountry = Console.ReadLine();

        //Create one ExpressShipment.
        InternationalShipment internationlShipment = new InternationalShipment(
            InternationlTrackingCode,
            InternationlDescription,
            InternationlWeight,
            InternationlDeliveryFee,
            destinationCountry,
            customsFee
            );

        Console.WriteLine();

        // Add ExpressShipment
        if (deliveryCenter.AddShipment(internationlShipment))
        {
            Console.WriteLine("Shipment Add Successfully ");

        }
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        #endregion

        #region Print All Shipments

        // Print all shipments in the delivery center.
        Console.WriteLine();
        Console.WriteLine("All Shipments in the Delivery Center:");
        Console.WriteLine();

        deliveryCenter.printAll();

        #endregion

        #region Print trackingStatus of every shipment 

        // Print tracking status of every shipment in the delivery center.
        Console.WriteLine();
        Console.WriteLine("Tracking Status of Every Shipment:");
        Console.WriteLine();
        deliveryCenter.PrintTrackingStatuses();
        Console.WriteLine("-----------------------------");

        #endregion

        #region Print insuranceCost of every shipment

        // Print insurance cost of every shipment in the delivery center.
        Console.WriteLine();
        Console.WriteLine("Insurance Cost of Every Shipment:");
        Console.WriteLine();
        deliveryCenter.PrintInsurance();
        Console.WriteLine("-----------------------------");

        #endregion

        #region ITrackable[] array
        // Create an array of ITrackable and add all shipments to it.
        ITrackable[] trackableShipments = new Shipment[3];
        {
            trackableShipments[0] = standardShipment;
            trackableShipments[1] = expressShipment;
            trackableShipments[2] = internationlShipment;
        };

        for (int i = 0; i < trackableShipments.Length; i++)
        {
            Console.WriteLine(trackableShipments[i].GetTrackingStatus());
        }
        Console.WriteLine("-----------------------------");
        #endregion

        #region Iinsurable[] array
        // Create an array of IInsurable and add all shipments to it.
        IInsurable[] insurableShipments = new Shipment[3];
        {
            insurableShipments[0] = standardShipment;
            insurableShipments[1] = expressShipment;
            insurableShipments[2] = internationlShipment;
        };

        for (int i = 0; i < insurableShipments.Length; i++)
        {
            Console.WriteLine(insurableShipments[i].CalculateInsurance());
        }
        Console.WriteLine("-----------------------------");
        #endregion

        #endregion
    }
}