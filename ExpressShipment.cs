namespace c__oop_ass3;

public class ExpressShipment : Shipment
{
    private decimal extraFee;  //new property

    public decimal ExtraFee
    {
        get
        {
            return extraFee;
        }

        set
        {
            if (value >= 0)
            {
                extraFee = value;
            }
        }
    }

    public decimal EstimatedCost    // override
    {
        get
        {
            return DeliveryFee + (Weight * 5) + ExtraFee;
        }
    }

    public ExpressShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal extraFee  // new 
        ) : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee;
    }
}
