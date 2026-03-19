using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CombinePrizeResult Data Structure.
    /// </summary>
    [Serializable]
    public class CombinePrizeResult : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 红包整体发放结果，单张红包全部成功为SUCCESS，部分成功部分失败为PART_SUCCESS_PART_FAILED，这种情况需要联系BD确认
        /// </summary>
        [XmlElement("combine_prize_status")]
        public string CombinePrizeStatus { get; set; }

        /// <summary>
        /// reduce:满立减(满5元减3元)
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 单张红包发放结果
        /// </summary>
        [XmlArray("sub_prize_result_list")]
        [XmlArrayItem("sub_prize_result")]
        public List<SubPrizeResult> SubPrizeResultList { get; set; }

        /// <summary>
        /// 红包总面额，单位为分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }
    }
}
