using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [XmlElement("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
