using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshExposureRule Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshExposureRule : AopObject
    {
        /// <summary>
        /// 以刷新后的值决定是否展示进度条
        /// </summary>
        [XmlElement("process_open")]
        public bool ProcessOpen { get; set; }
    }
}
