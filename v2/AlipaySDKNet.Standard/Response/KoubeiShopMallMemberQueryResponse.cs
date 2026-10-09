using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiShopMallMemberQueryResponse.
    /// </summary>
    public class KoubeiShopMallMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 会员等级
        /// </summary>
        [XmlElement("card_level")]
        public string CardLevel { get; set; }

        /// <summary>
        /// 会员卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 会员积分
        /// </summary>
        [XmlElement("card_point")]
        public string CardPoint { get; set; }

        /// <summary>
        /// 用户是否开通会员卡
        /// </summary>
        [XmlElement("has_card")]
        public bool HasCard { get; set; }

        /// <summary>
        /// 用户是否授权过商圈交易
        /// </summary>
        [XmlElement("trade_authed")]
        public bool TradeAuthed { get; set; }
    }
}
