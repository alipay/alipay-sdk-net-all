using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletRullSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletRullSetModel : AopObject
    {
        /// <summary>
        /// biz_scene
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// product_code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 钱包模版ID
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }

        /// <summary>
        /// 钱包使用规则
        /// </summary>
        [XmlElement("wallet_use_rule")]
        public WalletUseRule WalletUseRule { get; set; }
    }
}
