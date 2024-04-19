using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletTemplateCreateResponse.
    /// </summary>
    public class AlipayCloudFundWalletTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的钱包id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
