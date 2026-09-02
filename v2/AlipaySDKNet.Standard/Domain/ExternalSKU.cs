using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalSKU Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalSKU : AopObject
    {
        /// <summary>
        /// 商家SKU编码
        /// </summary>
        [XmlElement("merchant_sku_bar_code")]
        public string MerchantSkuBarCode { get; set; }

        /// <summary>
        /// 商家SKU编码
        /// </summary>
        [XmlElement("merchant_sku_code")]
        public string MerchantSkuCode { get; set; }

        /// <summary>
        /// 划线价
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// SKU图片列表
        /// </summary>
        [XmlArray("pic_list")]
        [XmlArrayItem("external_item_pic")]
        public List<ExternalItemPic> PicList { get; set; }

        /// <summary>
        /// 售卖价
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 销售属性列表
        /// </summary>
        [XmlArray("sale_property_list")]
        [XmlArrayItem("external_item_propery")]
        public List<ExternalItemPropery> SalePropertyList { get; set; }

        /// <summary>
        /// 蚂蚁侧skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// sku供应状态，录入或者更新商品信息时不填 更新请走更新sku状态接口
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
