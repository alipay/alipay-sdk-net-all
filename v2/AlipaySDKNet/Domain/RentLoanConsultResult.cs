using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentLoanConsultResult Data Structure.
    /// </summary>
    [Serializable]
    public class RentLoanConsultResult : AopObject
    {
        /// <summary>
        /// ALLOW：表示允许放款 FORBID：表示不允许放款
        /// </summary>
        [XmlElement("consult_result")]
        public string ConsultResult { get; set; }

        /// <summary>
        /// 资方信息的pid
        /// </summary>
        [XmlElement("invest_pid")]
        public string InvestPid { get; set; }
    }
}
