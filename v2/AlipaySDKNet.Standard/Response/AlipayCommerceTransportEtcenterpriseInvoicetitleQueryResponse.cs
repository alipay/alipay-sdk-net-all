using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoicetitleQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseInvoicetitleQueryResponse : AopResponse
    {
        /// <summary>
        /// 购方单位地址
        /// </summary>
        [XmlElement("buyer_addr")]
        public string BuyerAddr { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        [XmlElement("buyer_bank")]
        public string BuyerBank { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 单位名称或者姓名
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 抬头税号
        /// </summary>
        [XmlElement("buyer_tax_num")]
        public string BuyerTaxNum { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [XmlElement("buyer_tel")]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 发票抬头类型
        /// </summary>
        [XmlElement("title_type")]
        public string TitleType { get; set; }
    }
}
