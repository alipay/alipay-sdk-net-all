using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpBizIndicatorChildren Data Structure.
    /// </summary>
    [Serializable]
    public class VcpBizIndicatorChildren : AopObject
    {
        /// <summary>
        /// 指标code
        /// </summary>
        [XmlElement("target_code")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [XmlElement("target_name")]
        public string TargetName { get; set; }
    }
}
