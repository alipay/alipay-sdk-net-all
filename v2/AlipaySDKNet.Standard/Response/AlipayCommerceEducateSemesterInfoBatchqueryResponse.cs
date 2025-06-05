using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSemesterInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSemesterInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 学期信息列表
        /// </summary>
        [XmlArray("semester_list")]
        [XmlArrayItem("edu_semester_info")]
        public List<EduSemesterInfo> SemesterList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
