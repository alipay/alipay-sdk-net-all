using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyerunsignadmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainCreditpayBuyerunsignadmitQueryModel : AopObject
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [XmlElement("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [XmlElement("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 请求冥等ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// trace信息
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
