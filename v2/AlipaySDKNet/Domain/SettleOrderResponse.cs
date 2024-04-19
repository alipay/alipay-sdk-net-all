using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleOrderResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SettleOrderResponse : AopObject
    {
        /// <summary>
        /// 扣款单ID
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 分账明细
        /// </summary>
        [XmlArray("settle_detail_response_list")]
        [XmlArrayItem("settle_detail_response")]
        public List<SettleDetailResponse> SettleDetailResponseList { get; set; }

        /// <summary>
        /// 分账失败原因
        /// </summary>
        [XmlElement("settle_fail_reason")]
        public string SettleFailReason { get; set; }

        /// <summary>
        /// 分账失败次数
        /// </summary>
        [XmlElement("settle_fail_times")]
        public long SettleFailTimes { get; set; }

        /// <summary>
        /// 分账单ID
        /// </summary>
        [XmlElement("settle_order_id")]
        public string SettleOrderId { get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }
    }
}
