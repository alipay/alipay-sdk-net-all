using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySocialUserinformationExchangeResponse.
    /// </summary>
    public class AlipayEbppIndustrySocialUserinformationExchangeResponse : AopResponse
    {
        /// <summary>
        /// 加密的用户Id。
        /// </summary>
        [XmlElement("encrypt_id")]
        public string EncryptId { get; set; }

        /// <summary>
        /// 解密iv
        /// </summary>
        [XmlElement("sm_4_iv")]
        public string Sm4Iv { get; set; }
    }
}
