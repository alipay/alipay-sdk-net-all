using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIservicePromdatafactoryDataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIservicePromdatafactoryDataUploadModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("data_sync_request")]
        public List<DataSyncRequest> Data { get; set; }

        /// <summary>
        /// 租户标识
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
