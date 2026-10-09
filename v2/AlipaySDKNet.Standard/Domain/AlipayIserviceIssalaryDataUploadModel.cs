using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIssalaryDataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIssalaryDataUploadModel : AopObject
    {
        /// <summary>
        /// 结算数据日期入参
        /// </summary>
        [XmlElement("data_day")]
        public string DataDay { get; set; }

        /// <summary>
        /// 结算指标详情数据，单位分
        /// </summary>
        [XmlArray("salary_data")]
        [XmlArrayItem("salary_data_detail")]
        public List<SalaryDataDetail> SalaryData { get; set; }
    }
}
