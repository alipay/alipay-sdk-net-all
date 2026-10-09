using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoicetitleAlipaytradeQueryResponse.
    /// </summary>
    public class AlipayEbppInvoicetitleAlipaytradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行账号
        /// </summary>
        [XmlElement("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 用户私人手机号（交付用）
        /// </summary>
        [XmlElement("tele_phone_no")]
        public string TelePhoneNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [XmlElement("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 抬头类型 字段值有两种情况抬: PERSONAL（个人） CORPORATION（企业）
        /// </summary>
        [XmlElement("title_type")]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 用户私人邮箱（交付用）
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
