using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessBillGoodsQueryPageVO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessBillGoodsQueryPageVO : AopObject
    {
        /// <summary>
        /// 一级分类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 能效等级
        /// </summary>
        [XmlElement("energy_efficiency_level")]
        public string EnergyEfficiencyLevel { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 商品型号
        /// </summary>
        [XmlElement("goods_model_number")]
        public string GoodsModelNumber { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品价格，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [XmlElement("sub_category")]
        public string SubCategory { get; set; }
    }
}
