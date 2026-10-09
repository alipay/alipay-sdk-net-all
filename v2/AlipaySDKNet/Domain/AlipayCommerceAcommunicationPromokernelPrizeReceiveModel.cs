using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationPromokernelPrizeReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationPromokernelPrizeReceiveModel : AopObject
    {
        /// <summary>
        /// 用户唯一标识，可以通过端内的jsApi进行获取。其实就是2088开头的支付宝ID。
        /// </summary>
        [XmlElement("alipay_user_unique_identifier")]
        public string AlipayUserUniqueIdentifier { get; set; }

        /// <summary>
        /// 活动平台活动ID，活动唯一标记。
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("receive_order_ids")]
        [XmlArrayItem("string")]
        public List<string> ReceiveOrderIds { get; set; }
    }
}
