using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpICPRegistrationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpICPRegistrationInfo : AopObject
    {
        /// <summary>
        /// 网站域名
        /// </summary>
        [XmlArray("domain_name")]
        [XmlArrayItem("string")]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// 审核通过时间
        /// </summary>
        [XmlElement("shtgsj")]
        public string Shtgsj { get; set; }

        /// <summary>
        /// 网站名称
        /// </summary>
        [XmlElement("web_name")]
        public string WebName { get; set; }

        /// <summary>
        /// 网站备案/许可证号
        /// </summary>
        [XmlElement("wzbaxkzh")]
        public string Wzbaxkzh { get; set; }

        /// <summary>
        /// 主办单位名称
        /// </summary>
        [XmlElement("zbdwmc")]
        public string Zbdwmc { get; set; }
    }
}
