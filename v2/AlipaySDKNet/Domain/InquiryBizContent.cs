using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InquiryBizContent Data Structure.
    /// </summary>
    [Serializable]
    public class InquiryBizContent : AopObject
    {
        /// <summary>
        /// 是否存在预问诊病例
        /// </summary>
        [XmlElement("has_record")]
        public bool HasRecord { get; set; }
    }
}
