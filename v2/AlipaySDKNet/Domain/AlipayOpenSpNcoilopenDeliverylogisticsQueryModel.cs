using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenDeliverylogisticsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenDeliverylogisticsQueryModel : AopObject
    {
        /// <summary>
        /// 订单流水号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }
    }
}
