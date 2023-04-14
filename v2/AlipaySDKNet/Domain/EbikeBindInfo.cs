using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EbikeBindInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EbikeBindInfo : AopObject
    {
        /// <summary>
        /// 电动车品牌唯一标识
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 电动车品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 设备是否支持上报里程
        /// </summary>
        [XmlElement("can_report_riding_distance")]
        public bool CanReportRidingDistance { get; set; }

        /// <summary>
        /// 智能电动车名称
        /// </summary>
        [XmlElement("ebike_name")]
        public string EbikeName { get; set; }

        /// <summary>
        /// 智能电动车编号
        /// </summary>
        [XmlElement("ebike_no")]
        public string EbikeNo { get; set; }

        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("is_bind")]
        public bool IsBind { get; set; }
    }
}
