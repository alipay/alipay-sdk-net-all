using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateAuthQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权申请单状态，如有多个授权申请单，返回其中一个申请单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
