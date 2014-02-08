﻿using ApprovalTests;

namespace ObjectApproval
{
    public static class ObjectApprover
    {
        public static void VerifyWithJson(object target)
        {
            var serializeObject = SimpleJson.SerializeObject(target);
            var formatJson = serializeObject.FormatJson();
            Approvals.Verify(formatJson);
        }
    }
}