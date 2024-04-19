using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtWelfarefoundationVolunteersBatchqueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtWelfarefoundationVolunteersBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 志愿者活动时
        /// </summary>
        [XmlArray("activity_hours")]
        [XmlArrayItem("query_volunteers_dto")]
        public List<QueryVolunteersDto> ActivityHours { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
