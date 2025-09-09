using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderCancelModel : AopObject
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 此字段传取商家消订单的自定义原因，当reason_code=1299时，必填
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 此字段传取商家消订单的code
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }
    }
}
