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
        /// 商品的编号
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品未上报服务库时，需传入 上传商品文件 获取的 material_id。如果该商品已经上报服务库，可不传
        /// </summary>
        [XmlElement("image_material_id")]
        public string ImageMaterialId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商家商品Id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家商品out_sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 商品真实单价
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
