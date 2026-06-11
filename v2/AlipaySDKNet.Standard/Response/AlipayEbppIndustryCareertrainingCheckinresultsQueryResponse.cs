using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCheckinresultsQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingCheckinresultsQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("check_in_record_d_t_o")]
        public List<CheckInRecordDTO> List { get; set; }

        /// <summary>
        /// 总数量（条数）
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
