using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplate : AopObject
    {
        /// <summary>
        /// 卡归属的小程序appid
        /// </summary>
        [XmlElement("card_template_app_id")]
        public string CardTemplateAppId { get; set; }

        /// <summary>
        /// 支付宝侧卡ID，创建接口不需要传
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 卡名称（当card_type=AXF_MONEY_CARD时，查询会返回）
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 卡状态，创建接口不需要传
        /// </summary>
        [XmlElement("card_template_status")]
        public string CardTemplateStatus { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// <a href="https://opendocs.alipay.com/mini/e265db10_alipay.open.app.localitem.allcategory.query?pathHash=186a810a">获取类目接口文档</a>
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("hotline")]
        public string Hotline { get; set; }

        /// <summary>
        /// （1）当card_type=MERCHANT_TIMES_CARD或MERCHANT_PERIOD_PAY时，字段image_id_list和image_url_list必须二选一传入，image_id_list优先级更高 （2）查询返回时该字段为空，返回image_url_list （3）当card_type=AXF_MERCHANT_PERIOD_PAY或AXF_MONEY_CARD或AXF_PERIOD_PAY_INDIRECT 时，该字段选填，若该字段和image_url_list都不传，固定为一方小程序的图片url
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// （1）当card_type=MERCHANT_TIMES_CARD或MERCHANT_PERIOD_PAY时，字段image_id_list和image_url_list必须二选一传入，image_id_list优先级更高 （2）当card_type=AXF_MERCHANT_PERIOD_PAY或AXF_MONEY_CARD或AXF_PERIOD_PAY_INDIRECT 时，该字段选填，若该字段和image_url_list都不传，固定为一方小程序的图片url
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }

        /// <summary>
        /// 金额卡的必要参数。其他卡类型无需传入
        /// </summary>
        [XmlElement("money_card_info")]
        public MoneyCardInfo MoneyCardInfo { get; set; }

        /// <summary>
        /// 消息通知appId
        /// </summary>
        [XmlElement("msg_app_id")]
        public string MsgAppId { get; set; }

        /// <summary>
        /// 外部卡ID
        /// </summary>
        [XmlElement("out_card_id")]
        public string OutCardId { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlArray("reject_reasons")]
        [XmlArrayItem("card_reject_reason_info")]
        public List<CardRejectReasonInfo> RejectReasons { get; set; }

        /// <summary>
        /// 售卖信息
        /// </summary>
        [XmlElement("sale_info")]
        public CardTemplateSale SaleInfo { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 使用信息
        /// </summary>
        [XmlElement("use_info")]
        public CardTemplateUse UseInfo { get; set; }
    }
}
