using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNdapressUrgeResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNdapressUrgeResponse : AopResponse
    {
        /// <summary>
        /// 催签结果，true表示催签成功，异常表示催签失败
        /// </summary>
        [XmlElement("press_status")]
        public bool PressStatus { get; set; }
    }
}
