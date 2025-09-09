using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryorderSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataInquiryorderSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝行业侧订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
