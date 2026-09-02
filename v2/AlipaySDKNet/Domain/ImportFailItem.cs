using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImportFailItem Data Structure.
    /// </summary>
    [Serializable]
    public class ImportFailItem : AopObject
    {
        /// <summary>
        /// 行标识（如身份证号/ 企业名）
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 具体写入原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
