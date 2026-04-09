using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdAssignhistoryQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdAssignhistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("assign_finance_detail")]
        public List<AssignFinanceDetail> DataList { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
