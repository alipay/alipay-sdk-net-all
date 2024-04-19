using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAraterRatestatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAraterRatestatusModifyModel : AopObject
    {
        /// <summary>
        /// 业务扩展字段，传json字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 集团统一会员ID
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("rate_biz_source")]
        public string RateBizSource { get; set; }

        /// <summary>
        /// 评价id
        /// </summary>
        [XmlElement("rate_id")]
        public string RateId { get; set; }

        /// <summary>
        /// * 状态说明:      * CAN_NOT_RATE 不可评      * WAIT_FOR_RATE 待评价      * RATED_CAN_APPEND 已评价可追评      * RATED_CAN_NOT_APPEND 已评价不可追评
        /// </summary>
        [XmlElement("rate_status")]
        public string RateStatus { get; set; }

        /// <summary>
        /// 支付宝userId倒数2-3位
        /// </summary>
        [XmlElement("route_uid")]
        public string RouteUid { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
