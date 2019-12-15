using System;


namespace ConsoleApp2
{
    public class Object
    {
        public string Address { get; set; }
        public string FireExtinguishingSystem { get; set; }
        public string NotificationSystem { get; set; }
        public string QuantityFireExtinguisher { get; set; }
        public string EvacuationPlan { get; set; }
        public string AllInformation
        {
            get
            {
                return $"{Address}: {FireExtinguishingSystem},{NotificationSystem},{QuantityFireExtinguisher},{EvacuationPlan}";
            }
        }
    }
}
