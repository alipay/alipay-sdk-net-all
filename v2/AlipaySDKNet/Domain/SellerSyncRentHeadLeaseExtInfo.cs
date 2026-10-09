using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellerSyncRentHeadLeaseExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellerSyncRentHeadLeaseExtInfo : AopObject
    {
        /// <summary>
        /// 首租订单券后签约价，单位：元
        /// </summary>
        [XmlElement("head_lease_after_coupon_price")]
        public string HeadLeaseAfterCouponPrice { get; set; }

        /// <summary>
        /// 首租订单买断价，单位：元
        /// </summary>
        [XmlElement("head_lease_buyout_price")]
        public string HeadLeaseBuyoutPrice { get; set; }

        /// <summary>
        /// 首租订单历史逾期次数
        /// </summary>
        [XmlElement("head_lease_max_overdue_count")]
        public string HeadLeaseMaxOverdueCount { get; set; }

        /// <summary>
        /// 首租订单历史最大逾期天数，单位：天
        /// </summary>
        [XmlElement("head_lease_max_overdue_days")]
        public string HeadLeaseMaxOverdueDays { get; set; }

        /// <summary>
        /// 商户首租订单号
        /// </summary>
        [XmlElement("head_lease_order_id")]
        public string HeadLeaseOrderId { get; set; }

        /// <summary>
        /// 首租订单券前签约价，单位：元
        /// </summary>
        [XmlElement("head_lease_pre_coupon_price")]
        public string HeadLeasePreCouponPrice { get; set; }
    }
}
