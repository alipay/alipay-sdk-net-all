using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceAdditionalElementInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceAdditionalElementInfo : AopObject
    {
        /// <summary>
        /// 附加要素名称
        /// </summary>
        [XmlElement("element_name")]
        public string ElementName { get; set; }

        /// <summary>
        /// 附加要素类型
        /// </summary>
        [XmlElement("element_type")]
        public string ElementType { get; set; }

        /// <summary>
        /// 附加要素值
        /// </summary>
        [XmlElement("element_value")]
        public string ElementValue { get; set; }
    }
}
