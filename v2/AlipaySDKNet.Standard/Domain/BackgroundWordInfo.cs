using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BackgroundWordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BackgroundWordInfo : AopObject
    {
        /// <summary>
        /// 底纹词
        /// </summary>
        [XmlElement("background_word")]
        public string BackgroundWord { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 底纹词状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
