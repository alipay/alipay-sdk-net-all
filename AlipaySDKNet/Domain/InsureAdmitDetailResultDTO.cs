using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureAdmitDetailResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsureAdmitDetailResultDTO : AopObject
    {
        /// <summary>
        /// 批量请求的唯一识别key
        /// </summary>
        [XmlElement("echo_key")]
        public string EchoKey { get; set; }

        /// <summary>
        /// 准入失败code，只有risky是false的时候有
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 不准入描述
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// true是不准入，false是准入
        /// </summary>
        [XmlElement("risky")]
        public bool Risky { get; set; }
    }
}
