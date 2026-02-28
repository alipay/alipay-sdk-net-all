using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcTradeIdentityAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcTradeIdentityAccountInfo : AopObject
    {
        /// <summary>
        /// 门店间连收单账号认证绑定的UID
        /// </summary>
        [XmlElement("bind_uid")]
        public string BindUid { get; set; }

        /// <summary>
        /// 门店收单在企业码业务场景不可用原因
        /// </summary>
        [XmlElement("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 门店收单账号对应的脱敏登录ID：直连类型为收单账号对应的登录名称；间连类型为M4认证账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 门店收单对应商户的脱敏名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 门店收单账号可用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店收单对应的收单PID，直连商户为门店所属PID，间连商户为门店所属SMID
        /// </summary>
        [XmlElement("trade_pid")]
        public string TradePid { get; set; }

        /// <summary>
        /// 门店收单对应的支付宝门店ID
        /// </summary>
        [XmlElement("trade_shop_id")]
        public string TradeShopId { get; set; }

        /// <summary>
        /// 门店收单所属商户对应的类型（直连或间连）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
