using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthArchiveReverseModel : AopObject
    {
        /// <summary>
        /// 最外层包裹对象
        /// </summary>
        [XmlElement("content_data")]
        public ReverseContentData ContentData { get; set; }
    }
}
