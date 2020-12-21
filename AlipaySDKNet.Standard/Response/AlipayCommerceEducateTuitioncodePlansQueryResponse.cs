using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlansQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodePlansQueryResponse : AopResponse
    {
        /// <summary>
        /// 到账明细列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("instalment_plan_detail_tuition_d_t_o")]
        public List<InstalmentPlanDetailTuitionDTO> Data { get; set; }

        /// <summary>
        /// 分页号
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
