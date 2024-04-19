using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefererSetting Data Structure.
    /// </summary>
    [Serializable]
    public class RefererSetting : AopObject
    {
        /// <summary>
        /// 是否开启配置
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 是否允许空refer
        /// </summary>
        [XmlElement("no_refer_access")]
        public bool NoReferAccess { get; set; }

        /// <summary>
        /// refer配置列表
        /// </summary>
        [XmlArray("refer_list")]
        [XmlArrayItem("string")]
        public List<string> ReferList { get; set; }

        /// <summary>
        /// refer类型
        /// </summary>
        [XmlElement("refer_type")]
        public string ReferType { get; set; }
    }
}
