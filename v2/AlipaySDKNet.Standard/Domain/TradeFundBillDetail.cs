using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeFundBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TradeFundBillDetail : AopObject
    {
        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产类型编码
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 资产的属主
        /// </summary>
        [XmlElement("asset_user_id")]
        public string AssetUserId { get; set; }

        /// <summary>
        /// 资产的属主openid
        /// </summary>
        [XmlElement("asset_user_open_id")]
        public string AssetUserOpenId { get; set; }

        /// <summary>
        /// 支付业务类型  PAY-支付  REFUND-退款
        /// </summary>
        [XmlElement("biz_pay_type")]
        public string BizPayType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付单据号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }
    }
}
