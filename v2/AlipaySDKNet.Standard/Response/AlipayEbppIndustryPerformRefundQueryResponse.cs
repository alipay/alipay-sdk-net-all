using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryPerformRefundQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryPerformRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 行业受理平台的主订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("perform_bill")]
        public PerformBill PerformBill { get; set; }

        /// <summary>
        /// 退款单明细
        /// </summary>
        [XmlArray("refund_record_list")]
        [XmlArrayItem("perform_refund_query_record")]
        public List<PerformRefundQueryRecord> RefundRecordList { get; set; }
    }
}
