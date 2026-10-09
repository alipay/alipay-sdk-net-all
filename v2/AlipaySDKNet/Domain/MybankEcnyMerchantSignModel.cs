using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyMerchantSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyMerchantSignModel : AopObject
    {
        /// <summary>
        /// 协议类型，暂时只支持：FACE_TO_FACE_PAYMENT
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("business_address")]
        public EcnyAddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 商户证件影印件
        /// </summary>
        [XmlElement("cert_file")]
        public string CertFile { get; set; }

        /// <summary>
        /// 商户证件编号，按商户类型merchant_type的说明提供对应的证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型： IT01 居民身份证 IT02 军官证 IT03 护照 IT04 户口簿 IT05 士兵证 IT06 港澳往来内地通行证 IT07 台湾同胞来往内地通行证 IT08 临时身份证 IT09 外国人居留证 IT10 警官证 IT11 营业执照 IT12 组织机构代码 IT13 税务登记证 IT14 统一社会信用代码证 IT15 事业单位法人证书 IT16 社会团体法人登记证书 IT17 民办非企业单位登记证书 IT99 其他
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商户联系人信息。在本业务中，姓名，手机号必填，其他选填
        /// </summary>
        [XmlElement("concat_info")]
        public UserBaseInfo ConcatInfo { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一
        /// </summary>
        [XmlElement("ext_merchant_id")]
        public string ExtMerchantId { get; set; }

        /// <summary>
        /// 内景照，如果使用线下交易则必填
        /// </summary>
        [XmlArray("in_door_images")]
        [XmlArrayItem("string")]
        public List<string> InDoorImages { get; set; }

        /// <summary>
        /// 法定代表人\单位信息
        /// </summary>
        [XmlElement("legal_rep_info")]
        public UserBaseInfo LegalRepInfo { get; set; }

        /// <summary>
        /// 行业分类，参见《商家类目对应资质MCC2.0.xlsx》，只需填写二级类目code即可
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户别名。账单和结果页中的商户名称会展示此处设置的别名。如果涉及当面付场景，请填写线下店铺名称
        /// </summary>
        [XmlElement("merchant_alias_name")]
        public string MerchantAliasName { get; set; }

        /// <summary>
        /// 商户名称。一般情况下要与证件的名称相同。个体工商户类型可以放宽到法人名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户类型，参考单位类型： 01 企业法人 02 非企业法人 03 机关 04 实施预算管理的事业单位 05 非预算管理的事业单位 06 军队，武警团级（含）及以上单位以及分散执勤的支（分）队 07 社会团体 08 民办非企业组织 09 外地常设机构 10 外国驻华机构 11 个人工商户 12 居民委员会、村民委员会、社区委员会 13 独立核算的附属机构 14 其他机构
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 其他证件文件影印件
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
        /// 门头照，如果使用线下交易则必填
        /// </summary>
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 参考《商家类目对应资质MCC2.0.xlsx》，对应类目如果需要资质，需填写。参考《MCC2.0资质类型码.xlsx》,填写资质类型码。-1，无需上传对应资质文件影印件；1位、3位、4位数字需上传对应资质文件影印件。
        /// </summary>
        [XmlElement("qualification_file")]
        public string QualificationFile { get; set; }

        /// <summary>
        /// 参考《商家类目对应资质MCC2.0.xlsx》，对应类目如果需要资质，需填写。参考《MCC2.0资质类型码.xlsx》,填写资质类型码。-1，无需上传对应资质文件影印件；1位、3位、4位数字需上传对应资质文件影印件。
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }

        /// <summary>
        /// 服务费率（%）
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 钱包ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
