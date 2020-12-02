using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeApplySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeApplySendModel : AopObject
    {
        /// <summary>
        /// 外部申请单号
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 商户账户
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
