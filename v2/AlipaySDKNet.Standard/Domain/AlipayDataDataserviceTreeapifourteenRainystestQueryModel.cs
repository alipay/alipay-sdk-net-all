using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceTreeapifourteenRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceTreeapifourteenRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 完全copy引用复杂类型
        /// </summary>
        [XmlElement("req_copy_weak_ref")]
        public RainyComplexTypesTheFourteen ReqCopyWeakRef { get; set; }

        /// <summary>
        /// 字段copy引用
        /// </summary>
        [XmlElement("req_field_weak_ref")]
        public RainyComplexTypesTheFourteen ReqFieldWeakRef { get; set; }
    }
}
