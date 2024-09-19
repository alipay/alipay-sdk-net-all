using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobPayslipSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobPayslipSyncModel : AopObject
    {
        /// <summary>
        /// 发薪金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发薪银行卡编码，当发薪渠道为银行卡时，该字段必填 详情，编码详情参考：<a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/zax4z4wmsvuxalh2?singleDoc# 《银行简称》" target="_blank">全国银行简称</a>
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 发薪渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 发薪企业的信用代码
        /// </summary>
        [XmlElement("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 发薪企业的公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 用户账单信息有疑问时可通过该电话进行咨询。可提供发薪企业或您平台的客服电话
        /// </summary>
        [XmlElement("contact_info")]
        public string ContactInfo { get; set; }

        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发薪备注说明，该内容将会在账单信息中显示
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发薪时间
        /// </summary>
        [XmlElement("salary_time")]
        public string SalaryTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
