using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePreQueryResponse.
    /// </summary>
    public class AlipayTradePreQueryResponse : AopResponse
    {
        /// <summary>
        /// 卖家账号类型，1:单位、2:个人。
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }
    }
}
