using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBusinessbillGoodsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBusinessbillGoodsModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝分配的场景编码
        /// </summary>
        [XmlElement("activity_scene")]
        public string ActivityScene { get; set; }

        /// <summary>
        /// 一级分类，按品类维护，用于收款单内选商品时商品分组使用
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 能效等级，一级，二级
        /// </summary>
        [XmlElement("energy_efficiency_level")]
        public string EnergyEfficiencyLevel { get; set; }

        /// <summary>
        /// 修改后的商品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

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
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商品价格，单位:元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 二级分类；按品牌维护，用于收款单内选商品时商品分组使用
        /// </summary>
        [XmlElement("sub_category")]
        public string SubCategory { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
