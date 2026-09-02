using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinConfirmModel : AopObject
    {
        /// <summary>
        /// 花呗商户活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// activity_order_id和out_biz_no至少需要传一个：如果商家传入activity_order_id，则以activity_order_id为准；如果没有传，则以out_biz_no为准
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 123为1.23元，单位为分
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 行业场景标识,依赖双方约定
        /// </summary>
        [XmlElement("industry_value")]
        public string IndustryValue { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 20250613000206020000130052099451要保障修改某类权益的唯一性，需要进行mideng处理
        /// </summary>
        [XmlElement("operation_seq_id")]
        public string OperationSeqId { get; set; }

        /// <summary>
        /// 20250613000206020000130052099451需要和发放接口的out_biz_no保持一致，如果不传activity_order_id的时候
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
