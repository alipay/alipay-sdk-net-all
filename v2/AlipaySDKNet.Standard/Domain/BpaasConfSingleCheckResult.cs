using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BpaasConfSingleCheckResult Data Structure.
    /// </summary>
    [Serializable]
    public class BpaasConfSingleCheckResult : AopObject
    {
        /// <summary>
        /// 单项检测失败的原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 行业云单项配置检查是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 单项检测失败之后的操作提示
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }
    }
}
