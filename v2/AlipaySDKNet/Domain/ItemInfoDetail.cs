using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInfoDetail : AopObject
    {
        /// <summary>
        /// 创建药品的时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否医保标记；0不是 1是
        /// </summary>
        [XmlElement("insurance_status")]
        public string InsuranceStatus { get; set; }

        /// <summary>
        /// 由商家自定义
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 平台药品的编码，由支付宝返回
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 0上架 -1下架 -2冻结
        /// </summary>
        [XmlElement("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商家自定义店内父code
        /// </summary>
        [XmlElement("parent_tag_code")]
        public string ParentTagCode { get; set; }

        /// <summary>
        /// 平台商家店内父分类id
        /// </summary>
        [XmlElement("parent_tag_id")]
        public string ParentTagId { get; set; }

        /// <summary>
        /// 商家自定义店内父name
        /// </summary>
        [XmlElement("parent_tag_name")]
        public string ParentTagName { get; set; }

        /// <summary>
        /// sku信息
        /// </summary>
        [XmlElement("sku_info_list")]
        public SkuInfoVO SkuInfoList { get; set; }

        /// <summary>
        /// 商家自定义店内code
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 平台商家店内分类id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 平台商家店内分类id名称
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
