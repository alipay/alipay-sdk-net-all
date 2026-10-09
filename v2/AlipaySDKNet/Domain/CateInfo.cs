using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateInfo : AopObject
    {
        /// <summary>
        /// 类目code
        /// </summary>
        [XmlElement("cate_code")]
        public string CateCode { get; set; }

        /// <summary>
        /// 学段code
        /// </summary>
        [XmlElement("stage_code")]
        public string StageCode { get; set; }
    }
}
