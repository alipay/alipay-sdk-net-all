using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingRecruitPlanlistQueryResponse.
    /// </summary>
    public class AlipayMarketingRecruitPlanlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 方案列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("recruit_plan_light")]
        public List<RecruitPlanLight> Data { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
