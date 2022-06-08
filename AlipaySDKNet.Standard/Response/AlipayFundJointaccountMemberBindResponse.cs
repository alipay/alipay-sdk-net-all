using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountMemberBindResponse.
    /// </summary>
    public class AlipayFundJointaccountMemberBindResponse : AopResponse
    {
        /// <summary>
        /// 员工回应邀请链接
        /// </summary>
        [XmlElement("reply_url")]
        public string ReplyUrl { get; set; }
    }
}
