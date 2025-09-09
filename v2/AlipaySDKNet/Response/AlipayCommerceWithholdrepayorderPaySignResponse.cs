using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderPaySignResponse.
    /// </summary>
    public class AlipayCommerceWithholdrepayorderPaySignResponse : AopResponse
    {
        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }
    }
}
