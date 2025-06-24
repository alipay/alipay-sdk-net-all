using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 开户场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 商户确认开通场景钱包能力扩展参数
        /// </summary>
        [XmlElement("consume_extend")]
        public ConsumeExtend ConsumeExtend { get; set; }

        /// <summary>
        /// 如果存在大量入金笔数不出金场景，将该字段传为true。大量入金笔数且不出金场景，支付宝内部会有性能问题，一个钱包超过2000笔未核销笔数会阻断交易
        /// </summary>
        [XmlElement("has_large_details_scene")]
        public bool HasLargeDetailsScene { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 钱包名字
        /// </summary>
        [XmlElement("wallet_template_name")]
        public string WalletTemplateName { get; set; }

        /// <summary>
        /// 钱包使用规则
        /// </summary>
        [XmlElement("wallet_use_rule")]
        public WalletUseRule WalletUseRule { get; set; }
    }
}
