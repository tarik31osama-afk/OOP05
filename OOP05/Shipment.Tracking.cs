namespace OOP05
{
    public partial class Shipment
    {
        public string TrackingStatus { get;  set; }
        partial void OnTrackingStatusChanged(string newStatus);
      
        public void UpdateTrackingStatus(string status)
        {
            TrackingStatus = status;
            OnTrackingStatusChanged(status);
        }
        public virtual string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {TrackingStatus}.";
        }
        


    }
}
