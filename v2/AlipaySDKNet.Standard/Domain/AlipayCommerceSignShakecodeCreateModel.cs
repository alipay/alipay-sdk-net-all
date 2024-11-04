using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSignShakecodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSignShakecodeCreateModel : AopObject
    {
        /// <summary>
        /// 吱口令跳转链接
        /// </summary>
        [XmlElement("biz_linked_id")]
        public string BizLinkedId { get; set; }
    }
}
