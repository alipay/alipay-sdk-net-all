using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletTemplateConfirmResponse.
    /// </summary>
    public class AlipayFundWalletTemplateConfirmResponse : AopResponse
    {
        /// <summary>
        /// 钱包场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 钱包模版id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
