using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveLivedataCurrentliveQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveLivedataCurrentliveQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝直播间ID(加密后的)
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 支付宝主播生活号id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 是否需要收益单位,默认true
        /// </summary>
        [XmlElement("need_unit")]
        public bool NeedUnit { get; set; }
    }
}
