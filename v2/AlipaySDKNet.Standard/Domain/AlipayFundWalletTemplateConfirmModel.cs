using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletTemplateConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletTemplateConfirmModel : AopObject
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
        /// 礼品卡模版信息
        /// </summary>
        [XmlElement("gift_card_template")]
        public GiftCardTemplate GiftCardTemplate { get; set; }

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
    }
}
