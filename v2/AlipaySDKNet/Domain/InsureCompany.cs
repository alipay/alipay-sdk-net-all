using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureCompany Data Structure.
    /// </summary>
    [Serializable]
    public class InsureCompany : AopObject
    {
        /// <summary>
        /// 参与方唯一标识，当alipay_account_type为ALIPAY_USER_ID是表示支付宝2088uid,当alipay_account_type为ALIPAY_LOGON_ID时表示支付宝登录号
        /// </summary>
        [XmlElement("alipay_account_no")]
        public string AlipayAccountNo { get; set; }

        /// <summary>
        /// 账号主体id
        /// </summary>
        [XmlElement("alipay_account_open_id")]
        public string AlipayAccountOpenId { get; set; }

        /// <summary>
        /// 账号主体类型，默认ALIPAY_USER_ID
        /// </summary>
        [XmlElement("alipay_account_type")]
        public string AlipayAccountType { get; set; }

        /// <summary>
        /// 商户/企业名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型 社会信用编号 23 身份证号 10
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 渠道用户ID
        /// </summary>
        [XmlElement("channel_account_id")]
        public string ChannelAccountId { get; set; }

        /// <summary>
        /// 渠道用户ID
        /// </summary>
        [XmlElement("channel_account_open_id")]
        public string ChannelAccountOpenId { get; set; }

        /// <summary>
        /// 渠道用户类型
        /// </summary>
        [XmlElement("channel_account_type")]
        public string ChannelAccountType { get; set; }

        /// <summary>
        /// 企业社会信用编号
        /// </summary>
        [XmlElement("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业中文名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
