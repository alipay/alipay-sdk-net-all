using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MccInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MccInfo : AopObject
    {
        /// <summary>
        /// 调用方内部定义的MCC编号
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 和mcc_code对应的中文名称
        /// </summary>
        [XmlElement("mcc_name")]
        public string MccName { get; set; }
    }
}
