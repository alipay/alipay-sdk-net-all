using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HosInfoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HosInfoInfo : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 匹配得分，整数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
