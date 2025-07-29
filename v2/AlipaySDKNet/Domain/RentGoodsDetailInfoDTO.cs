using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentGoodsDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentGoodsDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品图片，用于小程序订单中心展示，可通过 alipay.merchant.item.file.upload 接口上传素材获取素材id。默认使用已上报的商品库素材信息。
        /// </summary>
        [XmlElement("image_material_id")]
        public string ImageMaterialId { get; set; }

        /// <summary>
        /// 品牌编号；参考租赁行业空间品牌编号文档
        /// </summary>
        [XmlElement("item_brand")]
        public string ItemBrand { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("item_category")]
        public string ItemCategory { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("item_description")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// 商品成色
        /// </summary>
        [XmlElement("item_fineness")]
        public string ItemFineness { get; set; }

        /// <summary>
        /// 成色等级，成色为二手时需传入此字段
        /// </summary>
        [XmlElement("item_fineness_grade")]
        public string ItemFinenessGrade { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品总价值，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("item_value")]
        public string ItemValue { get; set; }

        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户侧商品sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 租赁模式
        /// </summary>
        [XmlElement("rent_model")]
        public string RentModel { get; set; }

        /// <summary>
        /// 商品单价，单位：元，精确到小数点后两位，注：租赁商品请传入日租金，如10元/天
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 是否监管机
        /// </summary>
        [XmlElement("supervised")]
        public bool Supervised { get; set; }
    }
}
