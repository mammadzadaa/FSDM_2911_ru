using System;

namespace Interface_Segregation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IMessage
    {
        void Send();
        public string Sender { get; set; }
        public string Recipient { get; set; }
    }

    interface IVoiceMessage : IMessage
    {
        public byte[] ViceRecording { get; set; }
    }

    interface ITextMessage : IMessage
    {
        public string Text { get; set; }
    }

    interface IEmailMessage : ITextMessage
    {
        public string Subject { get; set; }
    }

    class VoiceMessage : IVoiceMessage
    {
        public byte[] ViceRecording { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Recipient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    class EmailMessage : IEmailMessage
    {
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Recipient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    //interface IMessage
    //{
    //    void Send();
    //    public string Text { get; set; }
    //    public string Subject { get; set; }
    //    public string Recipient { get; set; }
    //    public string Sender { get; set; }

    //}

    //class EmailMessange : IMessage
    //{
    //    public string Text { get; set; }
    //    public string Subject { get; set; }
    //    public string Recipient { get; set; }
    //    public string Sender { get; set; }

    //    public void Send()
    //    {
    //        Console.WriteLine("Email been sent");
    //    }
    //}

    //class SMSMessage : IMessage
    //{
    //    public string Text { get; set; }
    //    public string Recipient { get; set; }
    //    public string Sender { get; set; }
    //    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Send()
    //    {
    //        Console.WriteLine("SMS been sent");
    //    }
    //}

}
