using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocRealtimeTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocRealtimeTransferModel : AopObject
    {
        /// <summary>
        /// 藏品上架时间
        /// </summary>
        [XmlElement("asset_on_sale_time")]
        public string AssetOnSaleTime { get; set; }

        /// <summary>
        /// 流转来源用户ID
        /// </summary>
        [XmlElement("from_id_no")]
        public string FromIdNo { get; set; }

        /// <summary>
        /// 流转来源用户ID类型
        /// </summary>
        [XmlElement("from_id_type")]
        public string FromIdType { get; set; }

        /// <summary>
        /// 流转来源用户合作方内部用户ID
        /// </summary>
        [XmlElement("from_partner_id_no")]
        public string FromPartnerIdNo { get; set; }

        /// <summary>
        /// 流转来源用户合作方内部用户手机号
        /// </summary>
        [XmlElement("from_partner_phone_no")]
        public string FromPartnerPhoneNo { get; set; }

        /// <summary>
        /// 卖家注册3方账号时间
        /// </summary>
        [XmlElement("from_partner_register_time")]
        public string FromPartnerRegisterTime { get; set; }

        /// <summary>
        /// 资产nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 外部发起唯一业务单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部请求的ip
        /// </summary>
        [XmlElement("out_client_ip")]
        public string OutClientIp { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 合作方交易支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 预校验Id
        /// </summary>
        [XmlElement("pre_check_id")]
        public string PreCheckId { get; set; }

        /// <summary>
        /// 流转目标用户ID类型
        /// </summary>
        [XmlElement("to_id_no")]
        public string ToIdNo { get; set; }

        /// <summary>
        /// 流转目标用户ID类型
        /// </summary>
        [XmlElement("to_id_type")]
        public string ToIdType { get; set; }

        /// <summary>
        /// 流转目标用户合作方内部用户ID
        /// </summary>
        [XmlElement("to_partner_id_no")]
        public string ToPartnerIdNo { get; set; }

        /// <summary>
        /// 流转目标用户合作方内部用户手机号
        /// </summary>
        [XmlElement("to_partner_phone_no")]
        public string ToPartnerPhoneNo { get; set; }

        /// <summary>
        /// 买家注册3方账号时间
        /// </summary>
        [XmlElement("to_partner_register_time")]
        public string ToPartnerRegisterTime { get; set; }

        /// <summary>
        /// 流转金额，单位: 分
        /// </summary>
        [XmlElement("trade_cent")]
        public long TradeCent { get; set; }

        /// <summary>
        /// 交易订单号（三方支付机构订单号）
        /// </summary>
        [XmlElement("trade_order_no")]
        public string TradeOrderNo { get; set; }

        /// <summary>
        /// 上架确认id
        /// </summary>
        [XmlElement("verify_confirm_id")]
        public string VerifyConfirmId { get; set; }
    }
}
