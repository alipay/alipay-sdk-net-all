using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpPromoTargetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VcpPromoTargetInfo : AopObject
    {
        /// <summary>
        /// 营销目标
        /// </summary>
        [XmlElement("biz_indicator")]
        public VcpBizIndicator BizIndicator { get; set; }

        /// <summary>
        /// 目标数值
        /// </summary>
        [XmlElement("indicator_value")]
        public string IndicatorValue { get; set; }

        /// <summary>
        /// 业务域code
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 业务域名称
        /// </summary>
        [XmlElement("region_name")]
        public string RegionName { get; set; }
    }
}
