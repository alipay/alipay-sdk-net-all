using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Singltem Data Structure.
    /// </summary>
    [Serializable]
    public class Singltem : AopObject
    {
        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("biz_item_id")]
        public string BizItemId { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品有效期结束
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 商品的有效期开始
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// https://XX/zos/XX/zVDYRQDMoJaeJteGZtwx.png
        /// </summary>
        [XmlElement("item_redirect_url")]
        public string ItemRedirectUrl { get; set; }

        /// <summary>
        /// 商品展示图片链接
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品原价（单位：分）
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 售价（单位：分）
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品当前剩余库存，用于通知花呗测商品已售罄
        /// </summary>
        [XmlElement("remain_stock")]
        public long RemainStock { get; set; }

        /// <summary>
        /// 商品的总库存，用于展示“限量xx个”
        /// </summary>
        [XmlElement("total_stock")]
        public long TotalStock { get; set; }
    }
}
