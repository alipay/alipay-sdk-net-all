using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshMatchText Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshMatchText : AopObject
    {
        /// <summary>
        /// 当前进度命中的文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
