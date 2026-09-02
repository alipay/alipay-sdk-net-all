using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBsBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBsBillQueryModel : AopObject
    {
        /// <summary>
        /// 上次响应返回的 `next_cursor`。在非第一次调用时，相同查询入参（`plan_id`、`start_time`、`end_time`和`page_size`）需要回传该值，用于查询表示下一页
        /// </summary>
        [XmlElement("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// 按交易时间过滤的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否返回满足条件的总条数；不传默认为 `false`；计划下账单数量较多时，count 成本较高，推荐不传；仅第一页（`cursor`字段为空时）允许传true获取总数
        /// </summary>
        [XmlElement("need_count")]
        public bool NeedCount { get; set; }

        /// <summary>
        /// 单次返回的账单明细条数。不传时使用默认值 20；超过 100 返回参数错误
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 需要查询账单的品牌营销计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 按交易时间过滤的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
