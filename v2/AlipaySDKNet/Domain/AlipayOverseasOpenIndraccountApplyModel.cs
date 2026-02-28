using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndraccountApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndraccountApplyModel : AopObject
    {
        /// <summary>
        /// 账户名简称
        /// </summary>
        [XmlElement("account_abb_name")]
        public string AccountAbbName { get; set; }

        /// <summary>
        /// 收款人地址
        /// </summary>
        [XmlElement("account_address")]
        public IndrAddress AccountAddress { get; set; }

        /// <summary>
        /// 账户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 1. BANK_ACCOUNT账号 2. VCC账号
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行地址
        /// </summary>
        [XmlElement("bank_address")]
        public IndrAddress BankAddress { get; set; }

        /// <summary>
        /// 必填 VCC为Sunrate
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 关联机构id
        /// </summary>
        [XmlElement("beneficiary_id")]
        public string BeneficiaryId { get; set; }

        /// <summary>
        /// 账号币种编码
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 文件list
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("indr_file_info")]
        public List<IndrFileInfo> FileList { get; set; }

        /// <summary>
        /// 账号币种为GBP/EUR时需要iban
        /// </summary>
        [XmlElement("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// 收款账号,VCC默认95649503
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 1. 留学场景：TUITION 2. 租房场景：HOUSE_RENTAL
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 本地清算号，英国地区的bank_account账号需要
        /// </summary>
        [XmlElement("sort_code")]
        public string SortCode { get; set; }

        /// <summary>
        /// 电汇时需要swiftcode
        /// </summary>
        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }

        /// <summary>
        /// 学校官网
        /// </summary>
        [XmlElement("websites")]
        public string Websites { get; set; }
    }
}
