using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTaxTaxdataConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxTaxdataConfirmModel : AopObject
    {
        /// <summary>
        /// CN的用户id The Alipay user ID confirmed by the user and sent to the tax refund company in advance. Note: This field is required when refund_scene_type is a combined value. Example:20881042392127580377
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// The available days of the tax refund data, which ranges from 15 to 30 days. If the value of this field exceeds 30 and the tax refund is not processed, the tax refund has failed. Example:15
        /// </summary>
        [XmlElement("available_day")]
        public string AvailableDay { get; set; }

        /// <summary>
        /// The time is in GMT+8, and in a yyyy-mm-dd hh:mm:ss format. Example:2016-12-24 23:00:00
        /// </summary>
        [XmlElement("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// 两位字母代码KR-韩国
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Departure port Example:Inchon airport
        /// </summary>
        [XmlElement("departure_point")]
        public string DeparturePoint { get; set; }

        /// <summary>
        /// The time is in GMT+8, and in a yyyy-mm-dd hh:mm:ss format. Example:2016-12-24 23:00:00
        /// </summary>
        [XmlElement("doc_expire_date")]
        public string DocExpireDate { get; set; }

        /// <summary>
        /// 纸质退税单id
        /// </summary>
        [XmlElement("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 实际退税金额，数值，最多两位小数，例如人民币，单位为元 Example:308.50
        /// </summary>
        [XmlElement("final_refund_amount")]
        public string FinalRefundAmount { get; set; }

        /// <summary>
        /// The final currency of the country for tax refund. Only CNY is supported now. Example:CNY
        /// </summary>
        [XmlElement("final_refund_currency")]
        public string FinalRefundCurrency { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 退税业务完成，给商户发的通知消息
        /// </summary>
        [XmlElement("merchant_notify_url")]
        public string MerchantNotifyUrl { get; set; }

        /// <summary>
        /// 用户护照上的国际
        /// </summary>
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部商户id
        /// </summary>
        [XmlElement("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 退税机构业务流水号 唯一且最大长度不能超过64位，要求最小长度为3位
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 护照名
        /// </summary>
        [XmlElement("passport_name")]
        public string PassportName { get; set; }

        /// <summary>
        /// 护照号
        /// </summary>
        [XmlElement("passport_no")]
        public string PassportNo { get; set; }

        /// <summary>
        /// 退税金额，数值，最多两位小数，例如人民币，单位为元 Example:1400.00
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// The name of tax refund company, which the form initially belongs to. Example:Global Blue
        /// </summary>
        [XmlElement("refund_company_name")]
        public string RefundCompanyName { get; set; }

        /// <summary>
        /// 退税原始币种 三位字母代码
        /// </summary>
        [XmlElement("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// The time is in GMT+8, and in a yyyy-mm-dd hh:mm:ss format. Example:2016-12-24 23:00:00
        /// </summary>
        [XmlElement("refund_print_date")]
        public string RefundPrintDate { get; set; }

        /// <summary>
        /// The tax refund type. Valid values include: ● 01: Indicates urban refund ● 02: Indicates airport kiosk refund ● 03: Indicates airport real-time refund ● 06: Indicates mailbox refund Example:01
        /// </summary>
        [XmlElement("refund_scene_type")]
        public string RefundSceneType { get; set; }

        /// <summary>
        /// 购物金额，数值，最多两位小数，例如人民币，单位为元 Example:480000.00
        /// </summary>
        [XmlElement("sales_amount")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// The sales currency, which follows the ISO standard alpha-3 currency code. Example:KWR
        /// </summary>
        [XmlElement("sales_currency")]
        public string SalesCurrency { get; set; }

        /// <summary>
        /// 购物时间 The time is in GMT+8, and in a yyyy-mm-dd hh:mm:ss format. Example:2016-12-24 23:00:00
        /// </summary>
        [XmlElement("sales_date")]
        public string SalesDate { get; set; }

        /// <summary>
        /// 二级退税机构的pid
        /// </summary>
        [XmlElement("sub_trsp_id")]
        public string SubTrspId { get; set; }
    }
}
