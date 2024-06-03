using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDeliveryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentDeliveryDetail : AopObject
    {
        /// <summary>
        /// 物流类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 标准城市域码
        /// </summary>
        [XmlElement("receiver_division_code")]
        public string ReceiverDivisionCode { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }
    }
}
