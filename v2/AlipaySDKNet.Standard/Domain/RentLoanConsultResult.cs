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
        /// ALLOW：表示允许通过 FORBID：表示不允许通过 UN_KNOW：风险未知,无法识别
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
