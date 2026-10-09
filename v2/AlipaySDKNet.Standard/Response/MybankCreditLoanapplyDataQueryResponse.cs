using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyDataQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的对应的数据，大字段。
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据采集到的时间
        /// </summary>
        [XmlElement("data_time")]
        public string DataTime { get; set; }
    }
}
