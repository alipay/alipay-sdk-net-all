using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 商品的创建时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否为医保商品, 0不是, 1是, 默认1
        /// </summary>
        [XmlElement("insurance")]
        public string Insurance { get; set; }

        /// <summary>
        /// OMS厂商商品编码, 用于标识门店范围唯一一个商品, 厂商自行维护
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 平台商品的唯一键，由支付宝返回
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 门店商品的名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 门店商品关联的售卖规格列表
        /// </summary>
        [XmlArray("sku_info_list")]
        [XmlArrayItem("item_sku_info_d_t_o")]
        public List<ItemSkuInfoDTO> SkuInfoList { get; set; }

        /// <summary>
        /// 商品上下架状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品店内分类编码, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 商品店内分类末级分类的id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 商品店内分类名称, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 商品的最后一次修改时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
