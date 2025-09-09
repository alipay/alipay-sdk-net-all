using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSignFundAuthFreezeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentSignFundAuthFreezeInfoDTO : AopObject
    {
        /// <summary>
        /// 免押风控评估金额，即租押分离能力的押金评估金额。单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("risk_assessment_price")]
        public string RiskAssessmentPrice { get; set; }

        /// <summary>
        /// 风险评估方案ID
        /// </summary>
        [XmlElement("risk_scheme_id")]
        public string RiskSchemeId { get; set; }
    }
}
