using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmStagereportQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmStagereportQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("reports")]
        [XmlArrayItem("hm_stage_report")]
        public List<HmStageReport> Reports { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
