using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletTemplateCreateResponse.
    /// </summary>
    public class AlipayFundWalletTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户钱包模版id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
