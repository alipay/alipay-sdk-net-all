using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountQueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 企业营业执照图片正反面
        /// </summary>
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [XmlElement("enterprise_address")]
        public string EnterpriseAddress { get; set; }

        /// <summary>
        /// 企业所在地，市编码
        /// </summary>
        [XmlElement("enterprise_city")]
        public string EnterpriseCity { get; set; }

        /// <summary>
        /// 企业所在地，区编码
        /// </summary>
        [XmlElement("enterprise_district")]
        public string EnterpriseDistrict { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业所在地，省编码
        /// </summary>
        [XmlElement("enterprise_province")]
        public string EnterpriseProvince { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("enterprise_type")]
        public string EnterpriseType { get; set; }

        /// <summary>
        /// 在配送公司的账户状态信息
        /// </summary>
        [XmlArray("logistics_account_status")]
        [XmlArrayItem("logistics_account_status_d_t_o")]
        public List<LogisticsAccountStatusDTO> LogisticsAccountStatus { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
