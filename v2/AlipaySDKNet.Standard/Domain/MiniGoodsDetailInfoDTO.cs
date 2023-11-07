using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniGoodsDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniGoodsDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目树 当前字段已废弃(暂时未使用)
        /// </summary>
        [XmlElement("categories_tree")]
        public string CategoriesTree { get; set; }

        /// <summary>
        /// 商品类目 当前字段已废弃(暂时未使用)
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商户侧商品编号，提报优惠时的商品id，用于关联使用支付券，需要和支付券上绑定商品goods_id相同
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图片，用于小程序订单中心展示，可通过 alipay.merchant.item.file.upload接口上传素材获取素材id。默认使用已上报的商品库素材信息，已上报的商品可不传入，未上报商品库需传入。为空会导致订单展示异常
        /// </summary>
        [XmlElement("image_material_id")]
        public string ImageMaterialId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商户侧商品id，用于公域场景结算，会影响主播归因。私域场景无需传入，公域场景未传入会影响后续结算
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户侧商品sku_id，用于公域场景结算，如果商品有多个sku，需要传入准确的sku_id，无sku时不需要传入
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 平台商品版本号，用于查询商品快照
        /// </summary>
        [XmlElement("platform_item_version_id")]
        public string PlatformItemVersionId { get; set; }

        /// <summary>
        /// 租金信息，租赁商品特有
        /// </summary>
        [XmlElement("rent_info")]
        public RentInfoDTO RentInfo { get; set; }

        /// <summary>
        /// 商品单价，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 商品真实单价，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("sale_real_price")]
        public string SaleRealPrice { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [XmlElement("show_url")]
        public string ShowUrl { get; set; }
    }
}
