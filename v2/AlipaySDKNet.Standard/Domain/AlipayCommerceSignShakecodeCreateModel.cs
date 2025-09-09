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

        /// <summary>
        /// SHARE_CODE：吱口令；SHORT_URL：短链接，不传默认为：SHARE_CODE
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
