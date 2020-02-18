using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditCreditriskDsddAdmitConsultResponse.
    /// </summary>
    public class MybankCreditCreditriskDsddAdmitConsultResponse : AopResponse
    {
        /// <summary>
        /// 在status为ADMIT时，此字段必填。 表示准入额度对应的等级，等级越高，额度越大。 目前值为1-3。
        /// </summary>
        [XmlElement("amt_grade")]
        public string AmtGrade { get; set; }

        /// <summary>
        /// 表示准入查询结果的状态信息。 ADMIT：准入 NO_ADMIT：不准入
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
