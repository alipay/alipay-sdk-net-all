using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAssistantProductConfig Data Structure.
    /// </summary>
    [Serializable]
    public class EpAssistantProductConfig : AopObject
    {
        /// <summary>
        /// 时长购买数量，是以duration_unit的值作为单位，例如3个 HALF_YEAR表示一年半
        /// </summary>
        [XmlElement("duration_quantity")]
        public long DurationQuantity { get; set; }

        /// <summary>
        /// 购买会员包的时长单位(目前支持HALF_YEAR和YEAR两个选项)，生效与本结构的购买数量(duration_quantity)结合使用，如购买3个HALF_YEAR表示一年半。
        /// </summary>
        [XmlElement("duration_unit")]
        public string DurationUnit { get; set; }

        /// <summary>
        /// 购买的license数量，总量不多于300
        /// </summary>
        [XmlElement("license_num")]
        public long LicenseNum { get; set; }
    }
}
