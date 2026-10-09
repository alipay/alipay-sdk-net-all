using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletRuleSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletRuleSetModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 类型：config:配置，delete：删除
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
