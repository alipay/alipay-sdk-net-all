using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdTarget Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdTarget : AopObject
    {
        /// <summary>
        /// 目标用户id，如淘宝userid
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 目标账户类型，需要和人群类型保持一致
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
