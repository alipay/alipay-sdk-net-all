using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourOrderSyncDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TourOrderSyncDetail : AopObject
    {
        /// <summary>
        /// 可核销总数。凭证可核销数量总和
        /// </summary>
        [XmlElement("biz_source_num")]
        public string BizSourceNum { get; set; }

        /// <summary>
        /// 下单用户身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 下单用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 订单金额，单位：元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单详情信息。 例如订单的对应各状态时间 创建时间create_time, 退款时间refund_time, 出票时间delivered_time。 时间格式必须是yyyy-MM-dd HH:mm:SS格式。
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 订单状态。 TRANSACTION_SUCCESS --交易成功, REFUNDED -- 已退款, DELIVERED -- 已出票, USED -- 已核销
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 项目id。由支付宝分配
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 下单用户手机号
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tour_voucher_list")]
        [XmlArrayItem("tour_voucher_detail")]
        public List<TourVoucherDetail> TourVoucherList { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
