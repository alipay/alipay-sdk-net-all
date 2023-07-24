using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLeaseEnrollQueryResponse.
    /// </summary>
    public class AlipayCommerceLeaseEnrollQueryResponse : AopResponse
    {
        /// <summary>
        /// 租赁商报名计划信息列表
        /// </summary>
        [XmlArray("enroll_list")]
        [XmlArrayItem("lease_enroll_d_t_o")]
        public List<LeaseEnrollDTO> EnrollList { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
