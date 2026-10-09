using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentZhimazuwuOrderCheckResponse.
    /// </summary>
    public class AlipayCommerceRentZhimazuwuOrderCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否是放心发订单
        /// </summary>
        [XmlElement("free_to_send_scene")]
        public string FreeToSendScene { get; set; }
    }
}
