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
        /// 商品类目树
        /// </summary>
        [XmlElement("categories_tree")]
        public string CategoriesTree { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商户侧商品的编号，应传入商品最小粒度的商品ID（例如商品有sku粒度，则传商户sku粒度的ID）。如果需要关联使用支付券，需要和支付券上绑定商品goods_id相同
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品未上报商品库时，需传入  上传商品文件接口alipay.merchant.item.file.upload  获取的 material_id。如果该商品已经上报商品库，可不传
        /// </summary>
        [XmlElement("image_material_id")]
        public string ImageMaterialId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商户商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户商品sku_id，提报商品库的商品，该字段必传
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
