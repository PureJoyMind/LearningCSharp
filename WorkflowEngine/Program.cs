using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkFlowEngine();
            engine.AddWorkflow(new UploadWorkflow());
            engine.AddWorkflow(new SendEmailWorkflow());
            engine.Run();
        }
    }
}
