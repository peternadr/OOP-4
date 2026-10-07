namespace DeliverySystem.SmartDeliveryManagementSystem;

public class StandardShipment : Shipment, ITrackable
{

    #region constructor
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee)
    {
    }

    #endregion

    #region Methods

    public override void PrintShipment()
    {
        Console.WriteLine($"Tracking code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} KG");
        Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        Console.WriteLine($"Estimated cost: {EstimatedCost} EGP");
    }

    public override string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} is Ready";
    }

    #endregion
}
