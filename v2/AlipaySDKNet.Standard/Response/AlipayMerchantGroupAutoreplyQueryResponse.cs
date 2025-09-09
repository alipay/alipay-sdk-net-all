using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAutoreplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 自动回复详情
        /// </summary>
        [XmlElement("group_msg_autoreply_detail")]
        public GroupMsgAutoreplyDetailVO GroupMsgAutoreplyDetail { get; set; }
    }
}
