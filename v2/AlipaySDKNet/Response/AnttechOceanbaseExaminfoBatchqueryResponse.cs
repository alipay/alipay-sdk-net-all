using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseExaminfoBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseExaminfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户认证考试信息List
        /// </summary>
        [XmlArray("exam_infos")]
        [XmlArrayItem("exam_info_d_t_o")]
        public List<ExamInfoDTO> ExamInfos { get; set; }
    }
}
