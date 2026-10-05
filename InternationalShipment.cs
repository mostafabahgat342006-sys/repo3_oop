namespace c__oop_ass3;

public class InternationalShipment : Shipment
{
    private string destinationCountry;
    private decimal customsFee;

    public string DestinationCountry
    {
        get
        {
            return destinationCountry;
        }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                destinationCountry = value;
            }
        }
    }

    public decimal CustomsFee
    {
        get
        {
            return customsFee;
        }

        set
        {
            if (value >= 0)
            {
                customsFee = value;
            }
        }
    }

    public decimal EstimatedCost    // override
    {
        get
        {
            return DeliveryFee + (Weight * 5) + CustomsFee;
        }
    }

    public InternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry, // new 
        decimal customsFee   // new
        ) : base(trackingCode, description, weight, deliveryFee, destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }
}
