using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡商品信息
        /// </summary>
        [XmlElement("data")]
        public TimeCardItemInfo Data { get; set; }
    }
}
