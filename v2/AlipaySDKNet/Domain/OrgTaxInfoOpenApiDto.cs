using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgTaxInfoOpenApiDto Data Structure.
    /// </summary>
    [Serializable]
    public class OrgTaxInfoOpenApiDto : AopObject
    {
        /// <summary>
        /// 银行账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 是否电子抵账
        /// </summary>
        [XmlElement("has_elec_account")]
        public bool HasElecAccount { get; set; }

        /// <summary>
        /// 是否支持网上认证
        /// </summary>
        [XmlElement("is_online_verify")]
        public bool IsOnlineVerify { get; set; }

        /// <summary>
        /// 是否支持发票扫描
        /// </summary>
        [XmlElement("is_scan")]
        public bool IsScan { get; set; }

        /// <summary>
        /// 组织code
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("org_id")]
        public long OrgId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlArray("rates")]
        [XmlArrayItem("string")]
        public List<string> Rates { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 抬头
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 纳税人类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
