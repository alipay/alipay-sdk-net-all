using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenidComplex Data Structure.
    /// </summary>
    [Serializable]
    public class OpenidComplex : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("json_string")]
        public string JsonString { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }
    }
}
