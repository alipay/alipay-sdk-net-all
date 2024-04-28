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
        /// 支付宝侧商品ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        [XmlElement("card_template_status")]
        public string CardTemplateStatus { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 商品类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品封面图ID
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// 商品封面图Url
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_card_id")]
        public string OutCardId { get; set; }

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
