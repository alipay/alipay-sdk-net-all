using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataHotelVerifySyncResponse.
    /// </summary>
    public class AlipayCommerceDataHotelVerifySyncResponse : AopResponse
    {
        /// <summary>
        /// 错误信息具体描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 对应入参中的shop_id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
