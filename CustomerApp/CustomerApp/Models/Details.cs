namespace CustomerApp.Models
{
    public class Details
    {
        public bool blacklisted { get; set; }
        public bool malicious_activity { get; set; }
        public bool malicious_activity_recent { get; set; }
        public bool spam { get; set; }
        public bool suspicious_tld { get; set; }
    }
}
