using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketPromotiontaskRelationQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketPromotiontaskRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 推广服务商信息列表
        /// </summary>
        [XmlArray("promotion_relations")]
        [XmlArrayItem("promotion_task_relation")]
        public List<PromotionTaskRelation> PromotionRelations { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
