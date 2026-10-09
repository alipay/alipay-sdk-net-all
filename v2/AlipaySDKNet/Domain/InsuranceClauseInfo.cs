using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuranceClauseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuranceClauseInfo : AopObject
    {
        /// <summary>
        /// 附加条款内容
        /// </summary>
        [XmlElement("additional_item")]
        public string AdditionalItem { get; set; }

        /// <summary>
        /// 主险条款代码
        /// </summary>
        [XmlElement("main_item_code")]
        public string MainItemCode { get; set; }

        /// <summary>
        /// 主险条款内容
        /// </summary>
        [XmlElement("main_item_content")]
        public string MainItemContent { get; set; }

        /// <summary>
        /// 特别约定
        /// </summary>
        [XmlElement("special")]
        public string Special { get; set; }
    }
}
