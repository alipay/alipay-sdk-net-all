using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsTradeEventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsTradeEventSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 小件员用户标识
        /// </summary>
        [XmlElement("expressman_open_id")]
        public string ExpressmanOpenId { get; set; }

        /// <summary>
        /// 小件员支付宝用户id
        /// </summary>
        [XmlElement("expressman_user_id")]
        public string ExpressmanUserId { get; set; }

        /// <summary>
        /// 激励码值
        /// </summary>
        [XmlElement("incentive_code")]
        public string IncentiveCode { get; set; }

        /// <summary>
        /// 商户标识（接口调用方的渠道编码，由支付宝分配）
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// ALIPAY 支付宝操作渠道 OTHER 其他渠道
        /// </summary>
        [XmlElement("operation_source")]
        public string OperationSource { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付者用户标识
        /// </summary>
        [XmlElement("pay_open_id")]
        public string PayOpenId { get; set; }

        /// <summary>
        /// 支付者支付宝用户id
        /// </summary>
        [XmlElement("pay_user_id")]
        public string PayUserId { get; set; }

        /// <summary>
        /// 商户侧运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
