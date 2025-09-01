using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseGatewayDomainDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseGatewayDomainDeleteResponse : AopResponse
    {
        /// <summary>
        /// 接口调用信息
        /// </summary>
        [XmlElement("operation_info")]
        public bool OperationInfo { get; set; }
    }
}
