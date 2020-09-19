using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class CateInfoVO : AopObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
