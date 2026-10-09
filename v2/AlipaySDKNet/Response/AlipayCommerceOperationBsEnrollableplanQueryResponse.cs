using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollableplanQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationBsEnrollableplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 可报名计划列表
        /// </summary>
        [XmlArray("enroll_list")]
        [XmlArrayItem("bs_enrollable_plan")]
        public List<BsEnrollablePlan> EnrollList { get; set; }

        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询数据总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
