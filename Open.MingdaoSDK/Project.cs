using System;
using System.Collections.Generic;
using System.Text;
using Open.MingdaoSDK;
using Open.MingdaoSDK.Common;
using Open.MingdaoSDK.Entity;
using System.Collections.Specialized;

namespace Open.MingdaoSDK
{
    public class Project : MDAPIBase
    {
        public Project(Parameter u_key) : base(u_key) { }

        public ProjectModel GetProjectInfo()
        {
            string Result = base.SyncRequest(TypeOption.MD_Project, null, null);
            if (!string.IsNullOrEmpty(Result))
            {
                return XmlSerializationHelper.XmlToObject<ProjectModel>(Result);
            }
            return null;
        }
    }
}
