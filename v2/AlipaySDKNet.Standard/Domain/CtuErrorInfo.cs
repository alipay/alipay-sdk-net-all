using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CtuErrorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CtuErrorInfo : AopObject
    {
        /// <summary>
        /// ctu事件发送校验结果： success：校验通过；needRecheck：需要灰商户核身校验；failed：阻断业务
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }

        /// <summary>
        /// 风险咨询不通过的错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 风险咨询不通过的错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 风险文案编码
        /// </summary>
        [XmlElement("risk_temp_code")]
        public string RiskTempCode { get; set; }
    }
}
