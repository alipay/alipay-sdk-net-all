using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NetFlowDeviceOfferInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class NetFlowDeviceOfferInfoResponse : AopObject
    {
        /// <summary>
        /// 物联网卡卡状态
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 流量到期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 流量充值记录信息
        /// </summary>
        [XmlElement("net_flow_offer_info_list")]
        public NetFlowOfferInfo NetFlowOfferInfoList { get; set; }

        /// <summary>
        /// 充值金额描述
        /// </summary>
        [XmlElement("offer_amount")]
        public string OfferAmount { get; set; }

        /// <summary>
        /// 充值商品地址
        /// </summary>
        [XmlElement("offer_url")]
        public string OfferUrl { get; set; }
    }
}
