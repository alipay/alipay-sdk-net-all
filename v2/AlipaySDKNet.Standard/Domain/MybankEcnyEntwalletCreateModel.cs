using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyEntwalletCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyEntwalletCreateModel : AopObject
    {
        /// <summary>
        /// 实控人信息
        /// </summary>
        [XmlElement("act_ctl_info")]
        public UserBaseInfo ActCtlInfo { get; set; }

        /// <summary>
        /// 经办人/单位用户信息(经办人手机号和邮箱必填，便于接收开户意核实和开户结果的通知)
        /// </summary>
        [XmlElement("applicant_info")]
        public UserBaseInfo ApplicantInfo { get; set; }

        /// <summary>
        /// 受益人经常居住地或者工作单位地址
        /// </summary>
        [XmlElement("beneficiary_address")]
        public EcnyAddressInfo BeneficiaryAddress { get; set; }

        /// <summary>
        /// 受益人信息 (名称，证件类型，证件号码，证件有效期截止日期必填)
        /// </summary>
        [XmlElement("beneficiary_info")]
        public UserBaseInfo BeneficiaryInfo { get; set; }

        /// <summary>
        /// 单位联系人用户信息
        /// </summary>
        [XmlElement("contact_info")]
        public UserBaseInfo ContactInfo { get; set; }

        /// <summary>
        /// 单位经营地信息
        /// </summary>
        [XmlElement("ent_biz_addr")]
        public EcnyAddressInfo EntBizAddr { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("ent_biz_scope")]
        public string EntBizScope { get; set; }

        /// <summary>
        /// 单位证件有效期截止日期
        /// </summary>
        [XmlElement("ent_cert_date_invalid")]
        public string EntCertDateInvalid { get; set; }

        /// <summary>
        /// 单位证件有效期起始日期
        /// </summary>
        [XmlElement("ent_cert_date_valid")]
        public string EntCertDateValid { get; set; }

        /// <summary>
        /// 单位证件影印件，值为文件上传接口返回的文件ID
        /// </summary>
        [XmlElement("ent_cert_file")]
        public string EntCertFile { get; set; }

        /// <summary>
        /// 单位证件号
        /// </summary>
        [XmlElement("ent_cert_no")]
        public string EntCertNo { get; set; }

        /// <summary>
        /// 单位证件类型： IT11 营业执照 IT12 组织机构代码 IT13 税务登记证 IT14 统一社会信用代码证 IT15 事业单位法人证书 IT16 社会团体法人登记证书 IT17 民办非企业单位登记证书 IT99 其他
        /// </summary>
        [XmlElement("ent_cert_type")]
        public string EntCertType { get; set; }

        /// <summary>
        /// 行业分类，参见https://gw.alipayobjects.com/os/bmw-prod/b28421ce-0ddf-422f-9e9c-c2c3c7f30c73.xlsx
        /// </summary>
        [XmlElement("ent_mcc")]
        public string EntMcc { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("ent_reg_cap")]
        public string EntRegCap { get; set; }

        /// <summary>
        /// 单位税务登记证编号
        /// </summary>
        [XmlElement("ent_tax_id")]
        public string EntTaxId { get; set; }

        /// <summary>
        /// 单位类型： 01 企业法人 02 非企业法人 03 机关 04 实施预算管理的事业单位 05 非预算管理的事业单位 06 军队，武警团级（含）及以上单位以及分散执勤的支（分）队 07 社会团体 08 民办非企业组织 09 外地常设机构 10 外国驻华机构 11 个人工商户 12 居民委员会、村民委员会、社区委员会 13 独立核算的附属机构 14 其他机构
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

        /// <summary>
        /// 单位类型描述： 01 企业法人 02 非企业法人 03 机关 04 实施预算管理的事业单位 05 非预算管理的事业单位 06 军队，武警团级（含）及以上单位以及分散执勤的支（分）队 07 社会团体 08 民办非企业组织 09 外地常设机构 10 外国驻华机构 11 个人工商户 12 居民委员会、村民委员会、社区委员会 13 独立核算的附属机构 14 其他机构
        /// </summary>
        [XmlElement("ent_type_desc")]
        public string EntTypeDesc { get; set; }

        /// <summary>
        /// 法定代表人/单位负责人用户信息 (姓名，证件类型，证件号码，证件影印件，证件有效期截止日期必填)
        /// </summary>
        [XmlElement("legal_rep_info")]
        public UserBaseInfo LegalRepInfo { get; set; }

        /// <summary>
        /// 其他证件影印件
        /// </summary>
        [XmlArray("other_cert_files")]
        [XmlArrayItem("string")]
        public List<string> OtherCertFiles { get; set; }

        /// <summary>
        /// 其他证件类型，固定：IT99-其他
        /// </summary>
        [XmlElement("other_cert_type")]
        public string OtherCertType { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 1. IT_BANK:企业网银 — 通过2.5层机构的企业网银客户端发起的开户申请  2. EXTERNAL_ONLINE:外部线上平台 — 2.5层机构向其用户提供的开户申请平台/网站，包括：公众号、商户后台、H5页面、2.5层平台APP内等渠道  3. OFFLINE:线下收集 — 机构人员线下收集用户开户材料并发起的开户申请  4. OTHER:其他 — 其他
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 上级法人单位信息
        /// </summary>
        [XmlElement("super_legal_rep_info")]
        public UserBaseInfo SuperLegalRepInfo { get; set; }
    }
}
