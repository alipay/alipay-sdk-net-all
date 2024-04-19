using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimOfflineSyncResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcominsuInsuclaimOfflineSyncResponse : AopResponse
    {
        /// <summary>
        /// report_no_list+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("report_no_list")]
        [XmlArrayItem("string")]
        public List<string> ReportNoList { get; set; }
    }
}
