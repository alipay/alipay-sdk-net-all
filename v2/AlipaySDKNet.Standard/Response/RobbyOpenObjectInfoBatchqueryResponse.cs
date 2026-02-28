using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// RobbyOpenObjectInfoBatchqueryResponse.
    /// </summary>
    public class RobbyOpenObjectInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("object_status_list")]
        [XmlArrayItem("obj_status")]
        public List<ObjStatus> ObjectStatusList { get; set; }
    }
}
