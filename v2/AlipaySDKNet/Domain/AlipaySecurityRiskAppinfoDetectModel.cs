using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAppinfoDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskAppinfoDetectModel : AopObject
    {
        /// <summary>
        /// app或包信息
        /// </summary>
        [XmlElement("app_info_list")]
        public string AppInfoList { get; set; }

        /// <summary>
        /// 扩展配置信息
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 厂商标识
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
