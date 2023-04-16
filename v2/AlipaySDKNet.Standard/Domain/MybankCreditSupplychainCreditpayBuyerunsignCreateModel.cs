using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyerunsignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainCreditpayBuyerunsignCreateModel : AopObject
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
        /// 授权场景码
        /// </summary>
        [XmlElement("mybk_auth_scene_code")]
        public string MybkAuthSceneCode { get; set; }

        /// <summary>
        /// 授权令牌
        /// </summary>
        [XmlElement("mybk_auth_token")]
        public string MybkAuthToken { get; set; }

        /// <summary>
        /// 请求冥等控制ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
