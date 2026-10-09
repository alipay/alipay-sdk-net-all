using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceProxyorderQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceProxyorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权链接，未确认时返回。
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 农户确认时间，未确认时为空。
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 农户支付宝账号，按展示要求脱敏返回。
        /// </summary>
        [XmlElement("farmer_account_no")]
        public string FarmerAccountNo { get; set; }

        /// <summary>
        /// 农户支付宝账号类型。
        /// </summary>
        [XmlElement("farmer_account_type")]
        public string FarmerAccountType { get; set; }

        /// <summary>
        /// 农户姓名。
        /// </summary>
        [XmlElement("farmer_name")]
        public string FarmerName { get; set; }

        /// <summary>
        /// 服务商侧外部流水单号。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付订单号。
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }

        /// <summary>
        /// 代卖人支付宝账号，按展示要求脱敏返回。
        /// </summary>
        [XmlElement("proxy_account_no")]
        public string ProxyAccountNo { get; set; }

        /// <summary>
        /// 代卖人支付宝账号类型。
        /// </summary>
        [XmlElement("proxy_account_type")]
        public string ProxyAccountType { get; set; }

        /// <summary>
        /// 保证金，单位为元。
        /// </summary>
        [XmlElement("proxy_earnest_amount")]
        public string ProxyEarnestAmount { get; set; }

        /// <summary>
        /// 代卖人姓名。
        /// </summary>
        [XmlElement("proxy_name")]
        public string ProxyName { get; set; }

        /// <summary>
        /// 代卖人收购单ID。
        /// </summary>
        [XmlElement("proxy_order_id")]
        public string ProxyOrderId { get; set; }

        /// <summary>
        /// 收购单状态，可选值为NOT_CONFIRMED或CONFIRMED。
        /// </summary>
        [XmlElement("proxy_order_status")]
        public string ProxyOrderStatus { get; set; }
    }
}
