using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubPrizeResult Data Structure.
    /// </summary>
    [Serializable]
    public class SubPrizeResult : AopObject
    {
        /// <summary>
        /// 以分为单位，比如599，代表5.99元的面额
        /// </summary>
        [XmlElement("reduce_amount")]
        public long ReduceAmount { get; set; }

        /// <summary>
        /// 发放成功
        /// </summary>
        [XmlElement("sub_prize_status")]
        public string SubPrizeStatus { get; set; }

        /// <summary>
        /// 以分为单位，比如599，代表5.99元的门槛
        /// </summary>
        [XmlElement("threshold_amount")]
        public long ThresholdAmount { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
