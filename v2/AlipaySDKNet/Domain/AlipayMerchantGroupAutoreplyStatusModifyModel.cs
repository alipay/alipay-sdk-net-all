using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAutoreplyStatusModifyModel : AopObject
    {
        /// <summary>
        /// 自动回复id
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
