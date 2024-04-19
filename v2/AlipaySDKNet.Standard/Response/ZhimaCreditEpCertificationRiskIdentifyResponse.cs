using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCertificationRiskIdentifyResponse.
    /// </summary>
    public class ZhimaCreditEpCertificationRiskIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 认证风险识别结果集合
        /// </summary>
        [XmlArray("risk_identify_result")]
        [XmlArrayItem("string")]
        public List<string> RiskIdentifyResult { get; set; }

        /// <summary>
        /// 空壳企业等级，描述企业空壳程度。
        /// </summary>
        [XmlElement("shell_company_level")]
        public string ShellCompanyLevel { get; set; }
    }
}
