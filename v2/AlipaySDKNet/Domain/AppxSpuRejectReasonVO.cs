using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppxSpuRejectReasonVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppxSpuRejectReasonVO : AopObject
    {
        /// <summary>
        /// 备注原因
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 风险项名称
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }
    }
}
