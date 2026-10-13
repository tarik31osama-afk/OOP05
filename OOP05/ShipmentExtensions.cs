namespace OOP05
{
    public static class ShipmentExtensions
    {
       public static string GetSummary(this Shipment shipment)
        {

            return $"{shipment.TrackingCode} | {shipment.GetType().Name}| {shipment.Weight}|{((ITrackable)shipment).GetTrackingStatus()}";
            
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            return ((ITrackable)shipment).GetTrackingStatus() == "Delivered";

        }
    }
}
