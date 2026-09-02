using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoAwardQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoAwardQueryResponse : AopResponse
    {
        /// <summary>
        /// 激励金额，单位：分
        /// </summary>
        [XmlElement("award_amount")]
        public long AwardAmount { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 报名记录ID（已废弃，请勿依赖）
        /// </summary>
        [XmlElement("sign_up_id")]
        public string SignUpId { get; set; }

        /// <summary>
        /// 活动期间累计已发放激励（单位：分），与入参时间范围无关
        /// </summary>
        [XmlElement("total_awarded_amount")]
        public long TotalAwardedAmount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("trade_award_details")]
        [XmlArrayItem("trade_award_detail")]
        public List<TradeAwardDetail> TradeAwardDetails { get; set; }

        /// <summary>
        /// 总笔数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }
    }
}
