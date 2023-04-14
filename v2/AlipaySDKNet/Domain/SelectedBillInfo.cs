using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelectedBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SelectedBillInfo : AopObject
    {
        /// <summary>
        /// 账单id
        /// </summary>
        [XmlElement("bill_id")]
        public string BillId { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("billkey")]
        public string Billkey { get; set; }

        /// <summary>
        /// 缓存key
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }
    }
}
