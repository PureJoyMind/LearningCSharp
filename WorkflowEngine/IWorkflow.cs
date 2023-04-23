using System;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void Action();
    }

    public class UploadWorkflow : IWorkflow
    {
        public void Action()
        {
            FetchServer("http://www.FuckOff.com");
            Console.WriteLine("Uploading Image.");
        }

        private void FetchServer(string url)
        {
            Console.WriteLine($"Fetching server {url}...");
        }
    }

    public class SendEmailWorkflow : IWorkflow
    {
        public void Action()
        {
            Console.WriteLine("Sending email.");
        }
    }
}