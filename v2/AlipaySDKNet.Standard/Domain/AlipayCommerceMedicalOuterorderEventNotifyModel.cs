using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOuterorderEventNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOuterorderEventNotifyModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("consult_business")]
        public string ConsultBusiness { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_business")]
        public string EventBusiness { get; set; }

        /// <summary>
        /// 履约单id
        /// </summary>
        [XmlElement("fulfillment_order_id")]
        public string FulfillmentOrderId { get; set; }

        /// <summary>
        /// 履约单外部单号 也可以是子单号
        /// </summary>
        [XmlElement("partner_order_id")]
        public string PartnerOrderId { get; set; }

        /// <summary>
        /// 问诊事件详情
        /// </summary>
        [XmlElement("vedio_event_info")]
        public InquiryEventInfo VedioEventInfo { get; set; }
    }
}
