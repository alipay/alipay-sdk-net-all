using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGameopenpromoChallengeSubmitResponse.
    /// </summary>
    public class AlipayUserGameopenpromoChallengeSubmitResponse : AopResponse
    {
        /// <summary>
        /// 本次提交的当前状态
        /// </summary>
        [XmlElement("submit_status")]
        public string SubmitStatus { get; set; }
    }
}
