using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMemberbuyServiceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberbuyServiceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 请求会员频道场域的ID/投放渠道
        /// </summary>
        [XmlElement("delivery_channel")]
        public string DeliveryChannel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
