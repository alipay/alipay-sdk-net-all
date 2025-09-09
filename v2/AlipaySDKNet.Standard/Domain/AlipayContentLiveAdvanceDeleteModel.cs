using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveAdvanceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveAdvanceDeleteModel : AopObject
    {
        /// <summary>
        /// 用户生活号标识id
        /// </summary>
        [XmlElement("alipay_advance_id")]
        public string AlipayAdvanceId { get; set; }

        /// <summary>
        /// 用户生活号标识id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 预告删除原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
