using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAnnualReportBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAnnualReportBasicInfo : AopObject
    {
        /// <summary>
        /// 企业通信地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 企业控股情况
        /// </summary>
        [XmlElement("control_composition")]
        public string ControlComposition { get; set; }

        /// <summary>
        /// 企业电子邮箱
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 从业人数
        /// </summary>
        [XmlElement("employee_account")]
        public string EmployeeAccount { get; set; }

        /// <summary>
        /// 统一社会信用代码/注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 企业经营状态
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 是否有对外提供担保信息
        /// </summary>
        [XmlElement("has_external_guarantee")]
        public string HasExternalGuarantee { get; set; }

        /// <summary>
        /// 是否有投资信息或购买其他公司股权
        /// </summary>
        [XmlElement("has_external_invest")]
        public string HasExternalInvest { get; set; }

        /// <summary>
        /// 有限责任公司本年度是否发生股东股权转让
        /// </summary>
        [XmlElement("has_shareholder_equity_transfer")]
        public string HasShareholderEquityTransfer { get; set; }

        /// <summary>
        /// 是否有网站或网店
        /// </summary>
        [XmlElement("has_website")]
        public string HasWebsite { get; set; }

        /// <summary>
        /// 企业联系电话
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("postcode")]
        public string Postcode { get; set; }
    }
}
