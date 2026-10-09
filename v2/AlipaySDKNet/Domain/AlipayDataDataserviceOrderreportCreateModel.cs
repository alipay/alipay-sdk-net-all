using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceOrderreportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceOrderreportCreateModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 订单报表数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("report_data")]
        public List<ReportData> Data { get; set; }

        /// <summary>
        /// 外部平台订单id
        /// </summary>
        [XmlElement("order_outer_id")]
        public string OrderOuterId { get; set; }

        /// <summary>
        /// 订单数据报表日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
