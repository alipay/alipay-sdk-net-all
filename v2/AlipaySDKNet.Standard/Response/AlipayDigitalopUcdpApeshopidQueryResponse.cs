using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeshopidQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeshopidQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧门店ID，如果没有查询到会返回-1
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
