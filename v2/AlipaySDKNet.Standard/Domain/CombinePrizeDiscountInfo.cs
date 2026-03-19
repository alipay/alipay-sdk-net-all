using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CombinePrizeDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CombinePrizeDiscountInfo : AopObject
    {
        /// <summary>
        /// 可拆分
        /// </summary>
        [XmlElement("allow_voucher_split")]
        public string AllowVoucherSplit { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 单张红包优惠信息
        /// </summary>
        [XmlArray("sub_prize_list")]
        [XmlArrayItem("sub_prize_discount_info")]
        public List<SubPrizeDiscountInfo> SubPrizeList { get; set; }

        /// <summary>
        /// 总面额，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }
    }
}
