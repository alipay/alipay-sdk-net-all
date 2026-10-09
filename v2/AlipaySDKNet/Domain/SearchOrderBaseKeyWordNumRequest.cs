using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderBaseKeyWordNumRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderBaseKeyWordNumRequest : AopObject
    {
        /// <summary>
        /// appid
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
