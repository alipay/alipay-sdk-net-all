using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderBaseInfo : AopObject
    {
        /// <summary>
        /// 单位元
        /// </summary>
        [XmlElement("assess_amount")]
        public string AssessAmount { get; set; }

        /// <summary>
        /// 估价结果ID
        /// </summary>
        [XmlElement("estimate_result_id")]
        public string EstimateResultId { get; set; }

        /// <summary>
        /// 回收商订单ID
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 单位元
        /// </summary>
        [XmlElement("pre_assess_amount")]
        public string PreAssessAmount { get; set; }
    }
}
