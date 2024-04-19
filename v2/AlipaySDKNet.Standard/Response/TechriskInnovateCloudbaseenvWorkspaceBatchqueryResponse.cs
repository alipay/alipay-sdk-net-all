using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateCloudbaseenvWorkspaceBatchqueryResponse.
    /// </summary>
    public class TechriskInnovateCloudbaseenvWorkspaceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 环境变量集合
        /// </summary>
        [XmlArray("workspace_list")]
        [XmlArrayItem("workspace_v_o")]
        public List<WorkspaceVO> WorkspaceList { get; set; }
    }
}
