using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamecenterCoinQueryResponse.
    /// </summary>
    public class AlipayUserGamecenterCoinQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户游戏币余额，单位个，整数
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }
    }
}
