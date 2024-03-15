namespace GreenShare_Application.Data_models
{
    public class MessageCenter
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public bool ReadStatus { get; set; }
        public string Subject { get; set; }
        public List<string> Attachments { get; set; }
    }
}