using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyOverviewHighLight Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyOverviewHighLight : AopObject
    {
        /// <summary>
        /// 高亮文本。前端可以根据此字段内容高亮行文本中的部分文字。
        /// </summary>
        [XmlElement("high_light_text")]
        public string HighLightText { get; set; }
    }
}
