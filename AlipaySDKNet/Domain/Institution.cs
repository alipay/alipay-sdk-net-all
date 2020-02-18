using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Institution Data Structure.
    /// </summary>
    [Serializable]
    public class Institution : AopObject
    {
        /// <summary>
        /// 人行联行号
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 银行全称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
