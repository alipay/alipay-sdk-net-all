using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationUnionmemberActionSyncResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationUnionmemberActionSyncResponse : AopResponse
    {
        /// <summary>
        /// 回传成功的行为id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
