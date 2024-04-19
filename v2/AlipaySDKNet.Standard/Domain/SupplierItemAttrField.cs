using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierItemAttrField Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierItemAttrField : AopObject
    {
        /// <summary>
        /// 属性CODE
        /// </summary>
        [XmlElement("field_code")]
        public string FieldCode { get; set; }

        /// <summary>
        /// 属性名称描述
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("field_val")]
        public string FieldVal { get; set; }
    }
}
