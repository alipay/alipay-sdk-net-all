using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstBillInfo : AopObject
    {
        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 欠费金额
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单id，创单时使用
        /// </summary>
        [XmlElement("bill_id")]
        public string BillId { get; set; }

        /// <summary>
        /// 缓存key，创单时使用
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 缴费类型 预付费：PRE_PAY 后付费自由缴：POST_PAY_FREE_CHARGE 后付费缴清：POST_PAY_CLEAR_CHARGE
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [XmlElement("fine_amount")]
        public string FineAmount { get; set; }
    }
}
