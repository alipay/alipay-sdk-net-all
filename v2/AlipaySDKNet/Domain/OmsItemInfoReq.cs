using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OmsItemInfoReq Data Structure.
    /// </summary>
    [Serializable]
    public class OmsItemInfoReq : AopObject
    {
        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 创建药品的时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否为医保商品, 0不是, 1是, 默认0
        /// </summary>
        [XmlElement("insurance")]
        public string Insurance { get; set; }

        /// <summary>
        /// OMS厂商商品编码, 用于标识门店范围唯一一个商品, 厂商自行维护
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 平台药品的编码，由支付宝返回
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 门店商品的名称，例如：[地奥]银黄含片 0.65g*12片*2板
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 用于区分商品的修改端，枚举值：0 PC端 1 openapi
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 商品的售卖信息列表 当前字段已废弃(使用新字段替换老字段结构)
        /// </summary>
        [XmlElement("sku_info_list")]
        public OmsItemSkuInfoReq SkuInfoList { get; set; }

        /// <summary>
        /// 商品信息中sku售卖相关信息
        /// </summary>
        [XmlArray("sku_list_v_2")]
        [XmlArrayItem("oms_item_sku_info_req")]
        public List<OmsItemSkuInfoReq> SkuListV2 { get; set; }

        /// <summary>
        /// 枚举值：0-上架，-1-下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品店内分类编码, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 商品店内分类名称, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 最近一次更新药品的时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
