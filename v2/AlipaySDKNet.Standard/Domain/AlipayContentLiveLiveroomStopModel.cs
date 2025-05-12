using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveLiveroomStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveLiveroomStopModel : AopObject
    {
        /// <summary>
        /// 支付宝直播间id，创建直播间接口返回
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 用户生活号标识id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
