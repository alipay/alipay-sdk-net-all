using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenAccountConsultResponse.
    /// </summary>
    public class AlipayOverseasOpenAccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// isv请求结果
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }
    }
}
