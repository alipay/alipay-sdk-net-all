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
        /// 下单用户证件号。碰入园场景下，身份证和手机号二选一必填。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，传入证件号的同时需要传入证件类型，不传默认填充身份证。 身份证：IDENTITY_CARD 护照：PASSPORT 港澳居民通行证：HOME_VISIT_PERMIT_HK_MC 台湾居民通行证：HOME_VISIT_PERMIT_TAIWAN 港澳居民居住证：RESIDENCE_PERMIT_HK_MC 台湾居民居住证：RESIDENCE_PERMIT_TAIWAN 外国人永久居留证：PERMANENT_RESIDENCE_FOREIGNER
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

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
        /// 项目id，由支付宝分配。碰入园场景必填（取值由配置线圈的BD获取），一码通场景无需填写。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 凭证可用的场景类型，场景code（sceneCodes）为一码通（qrcode）时必须填写该参数，不传时默认为「免证登记」场景。
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 下单用户手机号。碰入园场景下，身份证和手机号二选一必填。
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
