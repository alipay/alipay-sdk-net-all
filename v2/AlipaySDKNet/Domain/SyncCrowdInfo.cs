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
        /// 来源app
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 外部app给出
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 业务code
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 操作的人群对象
        /// </summary>
        [XmlArray("operations")]
        [XmlArrayItem("crowd_operations")]
        public List<CrowdOperations> Operations { get; set; }

        /// <summary>
        /// 目标用户
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 目标类型
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
