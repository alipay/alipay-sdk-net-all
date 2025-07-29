using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsIncentivecodeOperationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsIncentivecodeOperationSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号 当前字段已废弃(支付成功相关参数，迁移到alipay.commerce.logistics.trade.event.sync接口)
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易成功状态 当前字段已废弃(支付成功相关参数，迁移到alipay.commerce.logistics.trade.event.sync接口)
        /// </summary>
        [XmlElement("alipay_trade_status")]
        public string AlipayTradeStatus { get; set; }

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
        /// SCAN(用户扫码) SEND_ORDER(用户寄件下单) RECEIVE_SUCCESS（揽收成功）
        /// </summary>
        [XmlElement("operation_dynamic_sales_type")]
        public string OperationDynamicSalesType { get; set; }

        /// <summary>
        /// 寄件用户操作时位置的纬度，单位：度
        /// </summary>
        [XmlElement("operation_latitude")]
        public string OperationLatitude { get; set; }

        /// <summary>
        /// 寄件用户操作时位置的经度，单位：度
        /// </summary>
        [XmlElement("operation_longitude")]
        public string OperationLongitude { get; set; }

        /// <summary>
        /// 寄件支付宝用户标识
        /// </summary>
        [XmlElement("operation_open_id")]
        public string OperationOpenId { get; set; }

        /// <summary>
        /// ALIPAY 支付宝操作渠道 OTHER 其他渠道
        /// </summary>
        [XmlElement("operation_source")]
        public string OperationSource { get; set; }

        /// <summary>
        /// 寄件用户操作时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 寄件支付宝用户id（当operation_source为OTHER渠道时，可不校验operation_open_id和operation_user_id是否同时为空）
        /// </summary>
        [XmlElement("operation_user_id")]
        public string OperationUserId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付完成页面链接（支付宝小程序链接） 当前字段已废弃(支付成功相关参数，迁移到alipay.commerce.logistics.trade.event.sync接口)
        /// </summary>
        [XmlElement("pay_finish_url")]
        public string PayFinishUrl { get; set; }

        /// <summary>
        /// 待支付页面链接（支付宝小程序链接） 当用户下单后有待支付链接请传 当前字段已废弃(支付成功相关参数，迁移到alipay.commerce.logistics.trade.event.sync接口)
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 运单号 当前字段已废弃(支付成功相关参数，迁移到alipay.commerce.logistics.trade.event.sync接口)
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
