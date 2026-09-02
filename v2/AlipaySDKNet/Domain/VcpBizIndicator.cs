using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpBizIndicator Data Structure.
    /// </summary>
    [Serializable]
    public class VcpBizIndicator : AopObject
    {
        /// <summary>
        /// 子集
        /// </summary>
        [XmlElement("children")]
        public VcpBizIndicatorChildren Children { get; set; }

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
