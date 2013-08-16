using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Enums;
using Umbraco.Forms.Core.Services;

namespace DeleteWorkflow
{
    public class DeleteWorkflow : WorkflowType
    {
        public DeleteWorkflow()
        {
            this.Id = new Guid("b40674bf-61f2-4203-bd4b-f71f0851a7c7");
            this.Name = "Delete record";
            this.Description = "Deletes the current record.";
        }

        public override List<Exception> ValidateSettings()
        {
            return new List<Exception>();
        }

        public override WorkflowExecutionStatus Execute(Record record, RecordEventArgs e)
        {
            using (RecordService rs = new RecordService(record))
            {
                rs.Delete();
            }

            return WorkflowExecutionStatus.Completed;
        }
    }
}