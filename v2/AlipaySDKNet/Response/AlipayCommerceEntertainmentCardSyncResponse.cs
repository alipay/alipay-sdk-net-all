using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEntertainmentCardSyncResponse.
    /// </summary>
    public class AlipayCommerceEntertainmentCardSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧会员卡卡号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 请求是否幂等。serial_number+biz_date为请求幂等键，biz_date小于等于serial_number对应会员卡在数据库的最新变更时间则请求幂等。
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }
    }
}
