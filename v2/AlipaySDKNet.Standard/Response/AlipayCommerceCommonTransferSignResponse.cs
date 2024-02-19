using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTransferSignResponse.
    /// </summary>
    public class AlipayCommerceCommonTransferSignResponse : AopResponse
    {
        /// <summary>
        /// 用于授权操作商户余额账户资金
        /// </summary>
        [XmlElement("operation_url")]
        public string OperationUrl { get; set; }
    }
}
