using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndraccountApplyResponse.
    /// </summary>
    public class AlipayOverseasOpenIndraccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 账号id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
