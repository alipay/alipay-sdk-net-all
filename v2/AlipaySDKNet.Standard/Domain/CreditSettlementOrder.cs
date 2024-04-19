using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditSettlementOrder Data Structure.
    /// </summary>
    [Serializable]
    public class CreditSettlementOrder : AopObject
    {
        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 订单原价
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 是否目标订单：true/false
        /// </summary>
        [XmlElement("target_order")]
        public bool TargetOrder { get; set; }
    }
}
