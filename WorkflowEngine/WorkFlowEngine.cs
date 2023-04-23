using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkFlowEngine
    {
        private readonly IList<IWorkflow> workflows;
        public WorkFlowEngine()
        {
            workflows = new List<IWorkflow>();
        }

        public void Run()
        {
            foreach (var workFlow in workflows)
            {
                workFlow.Action();
            }
        }

        public void AddWorkflow(IWorkflow workflow)
        {
            if (workflow == null)
            {
                throw new ArgumentNullException(nameof(workflow));
            }
            workflows.Add(workflow);
        }
        
    }
}