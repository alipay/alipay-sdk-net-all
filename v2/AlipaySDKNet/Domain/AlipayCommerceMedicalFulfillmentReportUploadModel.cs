using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentReportUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFulfillmentReportUploadModel : AopObject
    {
        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_infos")]
        [XmlArrayItem("fulfillment_report_info_d_t_o")]
        public List<FulfillmentReportInfoDTO> ReportInfos { get; set; }

        /// <summary>
        /// SAAS订单ID
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }
    }
}
