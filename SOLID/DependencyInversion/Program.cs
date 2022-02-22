using System;

namespace DependencyInversion
{
    class Program
    {
        /*Büyük sistemler küçüklere değil; küçükler büyüklere atanmalı....*/
        static void Main(string[] args)
        {
            Report report = new Report(new TeamsMessage());
            Report report2 = new Report(new DiscordMessage());
            Report report3 = new Report(new MailMessage());


        }
    }

    public class Report
    {
        private ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }
        public void Send()
        {

            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailMessage : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }
    public class TeamsMessage : ISender
    {
        public void Send()
        {
            Console.WriteLine("Teams ile gönderildi");
        }
    }

    public class DiscordMessage : ISender
    {
        public void Send()
        {
            Console.WriteLine("Discord ile gönderildi");
        }
    }
}
