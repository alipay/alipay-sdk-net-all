using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CampVoucherInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 券优惠金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 封顶金额，单位元
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券折扣
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 券优惠类型
        /// </summary>
        [XmlElement("discount_calc_type")]
        public string DiscountCalcType { get; set; }

        /// <summary>
        /// 门槛金额，单位元
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 本次可以使用改券的商品条码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 活动状态 INIT("INIT", "已创建"),     P_AUDIT("P_AUDIT", "已提交审核"),     AUDIT("AUDIT", "已审核"),     WAIT_ACTIVE("WAIT_ACTIVE","提交激活"),     ACTIVE("ACTIVE", "已发布"),     PAUSE("PAUSE", "已暂停"),     FINISHED("FINISHED", "已结束"),     DISCARD("DISCARD", "已废弃"),
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
