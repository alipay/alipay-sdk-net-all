using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncCrowdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SyncCrowdInfo : AopObject
    {
        /// <summary>
        /// 来源应用
        /// </summary>
        [XmlElement("auth_info")]
        public CrowdAuthInfo AuthInfo { get; set; }

        /// <summary>
        /// 操作的人群对象
        /// </summary>
        [XmlArray("operations")]
        [XmlArrayItem("crowd_operations")]
        public List<CrowdOperations> Operations { get; set; }

        /// <summary>
        /// 目标账号
        /// </summary>
        [XmlElement("target")]
        public CrowdTarget Target { get; set; }
    }
}
