using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasUserInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceGasUserInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 加密后数据，具体数据格式与支付宝小二对接
        /// </summary>
        [XmlElement("encrypted_data")]
        public string EncryptedData { get; set; }
    }
}
