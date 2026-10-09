using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceProxyorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceProxyorderCreateModel : AopObject
    {
        /// <summary>
        /// 农户支付宝账号，用于查询实名账户信息。
        /// </summary>
        [XmlElement("farmer_account_no")]
        public string FarmerAccountNo { get; set; }

        /// <summary>
        /// 农户支付宝账号类型，可选值为PHONE或EMAIL。
        /// </summary>
        [XmlElement("farmer_account_type")]
        public string FarmerAccountType { get; set; }

        /// <summary>
        /// 农户身份证号，用于核验农户实名信息。
        /// </summary>
        [XmlElement("farmer_cert_no")]
        public string FarmerCertNo { get; set; }

        /// <summary>
        /// 农户姓名，需要与农户支付宝实名信息一致。
        /// </summary>
        [XmlElement("farmer_name")]
        public string FarmerName { get; set; }

        /// <summary>
        /// 服务商侧请求流水号，用于接口幂等。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付订单号，用于关联支付链路与收购单。
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }

        /// <summary>
        /// 代卖人支付宝账号，用于查询实名账户信息。
        /// </summary>
        [XmlElement("proxy_account_no")]
        public string ProxyAccountNo { get; set; }

        /// <summary>
        /// 代卖人支付宝账号类型，可选值为PHONE或EMAIL。
        /// </summary>
        [XmlElement("proxy_account_type")]
        public string ProxyAccountType { get; set; }

        /// <summary>
        /// 代卖人身份证号，用于核验代卖人实名信息。
        /// </summary>
        [XmlElement("proxy_cert_no")]
        public string ProxyCertNo { get; set; }

        /// <summary>
        /// 保证金，用于收购单展示和后续分账计算，单位为元。
        /// </summary>
        [XmlElement("proxy_earnest_amount")]
        public string ProxyEarnestAmount { get; set; }

        /// <summary>
        /// 代卖人姓名，需要与代卖人支付宝实名信息一致。
        /// </summary>
        [XmlElement("proxy_name")]
        public string ProxyName { get; set; }
    }
}
