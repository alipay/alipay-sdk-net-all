using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMemberCitycardSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberCitycardSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务发生时间，YYYY-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_occur_time")]
        public string BizOccurTime { get; set; }

        /// <summary>
        /// 城市行政区域码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 外部会员卡卡号，唯一
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }

        /// <summary>
        /// 开卡支付支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 卡有效期结束时间，YYYY-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_end")]
        public string ValidEnd { get; set; }

        /// <summary>
        /// 卡有效期开始时间，YYYY-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_start")]
        public string ValidStart { get; set; }
    }
}
