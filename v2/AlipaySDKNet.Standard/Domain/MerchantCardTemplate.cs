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
        /// 商品归属的小程序appid
        /// </summary>
        [XmlElement("card_template_app_id")]
        public string CardTemplateAppId { get; set; }

        /// <summary>
        /// 支付宝侧商品ID，创建接口不需要传
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 商品状态，创建接口不需要传
        /// </summary>
        [XmlElement("card_template_status")]
        public string CardTemplateStatus { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// <a href="https://opendocs.alipay.com/mini/e265db10_alipay.open.app.localitem.allcategory.query?pathHash=186a810a">获取类目接口文档</a>
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// （1）当card_type!=AXF_MERCHANT_PERIOD_PAY,字段image_id_list和image_url_list必须二选一传入，，image_id_list优先级更高 （2）查询返回时该字段为空，返回image_url_list （3）当card_type=AXF_MERCHANT_PERIOD_PAY，该字段不传，固定为一方小程序的图片url；
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// （1）当card_type!=AXF_MERCHANT_PERIOD_PAY,字段image_id_list和image_url_list必须二选一传入，，image_id_list优先级更高 （2）当card_type=AXF_MERCHANT_PERIOD_PAY，该字段不传，固定为一方小程序的图片url；
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }

        /// <summary>
        /// 消息通知appId
        /// </summary>
        [XmlElement("msg_app_id")]
        public string MsgAppId { get; set; }

        /// <summary>
        /// 外部商品ID
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
