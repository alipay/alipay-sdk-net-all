using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSchooldeviceSmBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSchooldeviceSmBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 间连商户报名查询结果
        /// </summary>
        [XmlArray("edu_sm_activity_dto_list")]
        [XmlArrayItem("edu_sm_activity_d_t_o")]
        public List<EduSmActivityDTO> EduSmActivityDtoList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_result_size")]
        public long TotalResultSize { get; set; }
    }
}
