using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckReportData Data Structure.
    /// </summary>
    [Serializable]
    public class CheckReportData : AopObject
    {
        /// <summary>
        /// 是否支持回购认证， 90 天回购认证
        /// </summary>
        [XmlElement("buyback_auth")]
        public bool BuybackAuth { get; set; }

        /// <summary>
        /// 报告来源渠道
        /// </summary>
        [XmlElement("report_origin_code")]
        public string ReportOriginCode { get; set; }

        /// <summary>
        /// 车辆检测明细
        /// </summary>
        [XmlArray("vehicle_check_detail")]
        [XmlArrayItem("vehicle_check_detail_item")]
        public List<VehicleCheckDetailItem> VehicleCheckDetail { get; set; }

        /// <summary>
        /// 第三方质检报告url地址
        /// </summary>
        [XmlElement("vehicle_check_url")]
        public string VehicleCheckUrl { get; set; }

        /// <summary>
        /// 车辆不合适条件。车辆认证；
        /// </summary>
        [XmlArray("vehicle_exclusions")]
        [XmlArrayItem("string")]
        public List<string> VehicleExclusions { get; set; }

        /// <summary>
        /// 车辆评分
        /// </summary>
        [XmlElement("vehicle_score")]
        public string VehicleScore { get; set; }
    }
}
