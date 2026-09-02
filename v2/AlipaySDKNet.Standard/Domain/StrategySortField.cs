using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StrategySortField Data Structure.
    /// </summary>
    [Serializable]
    public class StrategySortField : AopObject
    {
        /// <summary>
        /// 排序字段编码
        /// </summary>
        [XmlElement("field_code")]
        public string FieldCode { get; set; }

        /// <summary>
        /// 排序方向：asc-升序，desc-降序
        /// </summary>
        [XmlElement("ort_by")]
        public string OrtBy { get; set; }
    }
}
