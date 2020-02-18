using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPeerpayprodAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝userId，用于亲情号被开通人
        /// </summary>
        [XmlElement("alipay_related_uid")]
        public string AlipayRelatedUid { get; set; }

        /// <summary>
        /// 支付宝userId，用于亲情号开通人
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
