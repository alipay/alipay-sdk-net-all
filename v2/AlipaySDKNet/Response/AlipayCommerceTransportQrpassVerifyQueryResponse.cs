using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportQrpassVerifyQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportQrpassVerifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否校验成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
