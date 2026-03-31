using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMpointAlllpointReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMpointAlllpointReceiveModel : AopObject
    {
        /// <summary>
        /// 用于标记调用方来源
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
