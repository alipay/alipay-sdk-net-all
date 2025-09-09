using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CouponDetail : AopObject
    {
        /// <summary>
        /// 活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 面额(分)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 优惠券编码
        /// </summary>
        [XmlElement("coupon_code")]
        public string CouponCode { get; set; }

        /// <summary>
        /// 优惠券内容详情
        /// </summary>
        [XmlElement("coupon_desc")]
        public string CouponDesc { get; set; }

        /// <summary>
        /// 优惠券标题
        /// </summary>
        [XmlElement("coupon_title")]
        public string CouponTitle { get; set; }

        /// <summary>
        /// 优惠券类型  - VOUCHER  - DISCOUNT
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 优惠券使用限制列表
        /// </summary>
        [XmlArray("coupon_use_products")]
        [XmlArrayItem("coupon_use_product")]
        public List<CouponUseProduct> CouponUseProducts { get; set; }

        /// <summary>
        /// 折扣（0-1）
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商品最大购买数量可用
        /// </summary>
        [XmlElement("purchase_max_num")]
        public string PurchaseMaxNum { get; set; }

        /// <summary>
        /// 商品最少购买数量可用
        /// </summary>
        [XmlElement("purchase_min_num")]
        public string PurchaseMinNum { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 优惠券状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 使用门槛-无门槛传0
        /// </summary>
        [XmlElement("use_threshold")]
        public string UseThreshold { get; set; }
    }
}
