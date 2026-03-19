using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationMcpPhoneRecommendResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationMcpPhoneRecommendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("phone_item_info")]
        public List<PhoneItemInfo> Items { get; set; }

        /// <summary>
        /// 手机号信息
        /// </summary>
        [XmlElement("mobile_info")]
        public MobilePhoneInfo MobileInfo { get; set; }

        /// <summary>
        /// 查询余额链接
        /// </summary>
        [XmlElement("query_balance_link")]
        public string QueryBalanceLink { get; set; }
    }
}
