using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseGatewayDomainCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseGatewayDomainCreateResponse : AopResponse
    {
        /// <summary>
        /// 域名创建返回信息
        /// </summary>
        [XmlElement("operation_info")]
        public bool OperationInfo { get; set; }
    }
}
