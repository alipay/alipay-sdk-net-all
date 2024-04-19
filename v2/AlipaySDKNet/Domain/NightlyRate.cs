using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NightlyRate Data Structure.
    /// </summary>
    [Serializable]
    public class NightlyRate : AopObject
    {
        /// <summary>
        /// 加床价 （BigDecimal）（元） -1表示不能加床
        /// </summary>
        [XmlElement("add_bed")]
        public string AddBed { get; set; }

        /// <summary>
        /// 划线价 （BigDecimal）（元）
        /// </summary>
        [XmlElement("basis")]
        public string Basis { get; set; }

        /// <summary>
        /// 早餐份数
        /// </summary>
        [XmlElement("breakfast")]
        public long Breakfast { get; set; }

        /// <summary>
        /// 结算价 （BigDecimal）（元） 仅用于结算价模式下的预付产品可用，非结算价模式下返回-1
        /// </summary>
        [XmlElement("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// 当天日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 会员价（BigDecimal）（元） 已经通过DRR的计算可以直接显示给客人。价格为-1表示不能销售
        /// </summary>
        [XmlElement("member")]
        public string Member { get; set; }

        /// <summary>
        /// 优惠金额 （BigDecimal）（元）
        /// </summary>
        [XmlElement("price_discount_value")]
        public string PriceDiscountValue { get; set; }

        /// <summary>
        /// 促销活动名
        /// </summary>
        [XmlElement("promotion_tag")]
        public string PromotionTag { get; set; }

        /// <summary>
        /// 促销类型 0:未定义, 1:天天特价, 2:门店新客
        /// </summary>
        [XmlElement("promotion_type")]
        public long PromotionType { get; set; }

        /// <summary>
        /// 库存状态 表示当天库存是否可用
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
