using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankStagedThresholdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankStagedThresholdInfo : AopObject
    {
        /// <summary>
        /// 满足优惠的订单金额阈值最大值，单位为分
        /// </summary>
        [XmlElement("max_threshold_amount")]
        public long MaxThresholdAmount { get; set; }

        /// <summary>
        /// 满足优惠条件的订单金额最小值,分为单位
        /// </summary>
        [XmlElement("min_threshold_amount")]
        public long MinThresholdAmount { get; set; }

        /// <summary>
        /// 该区间范围内的定价优惠策略 REDUCE_FIXED_AMOUNT：单笔固定立减 REDUCE_TO_AMOUNT：减至优惠
        /// </summary>
        [XmlElement("price_calc_type")]
        public string PriceCalcType { get; set; }

        /// <summary>
        /// 如果priceCalc=REDUCE_FIXED_AMOUNT，表示单笔立减5.55元； 如果priceCalc=REDUCE_TO_AMOUNT，表示当前订单优惠到5.55元(即实际支付5.55元)
        /// </summary>
        [XmlElement("reduce_amount")]
        public long ReduceAmount { get; set; }
    }
}
