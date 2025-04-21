using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddShopJoinNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddShopJoinNotifyModel : AopObject
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [XmlElement("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 待提交/审核中/审核通过/审核拒绝/待处理
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 银行账户类型
        /// </summary>
        [XmlElement("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// 开户行地址
        /// </summary>
        [XmlElement("bank_address")]
        public AddressBean BankAddress { get; set; }

        /// <summary>
        /// 开户支行
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 银行卡正面照
        /// </summary>
        [XmlElement("bank_card_front_pic")]
        public string BankCardFrontPic { get; set; }

        /// <summary>
        /// 银行卡卡号
        /// </summary>
        [XmlElement("bank_card_number")]
        public string BankCardNumber { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("business_entity_type")]
        public string BusinessEntityType { get; set; }

        /// <summary>
        /// 经营场景照
        /// </summary>
        [XmlElement("business_environment_pic")]
        public string BusinessEnvironmentPic { get; set; }

        /// <summary>
        /// 营业执照有效期结束时间
        /// </summary>
        [XmlElement("business_license_end_date")]
        public string BusinessLicenseEndDate { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [XmlElement("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业执照有效期开始时间
        /// </summary>
        [XmlElement("business_license_start_date")]
        public string BusinessLicenseStartDate { get; set; }

        /// <summary>
        /// 收银台照
        /// </summary>
        [XmlElement("cashier_desk_pic")]
        public string CashierDeskPic { get; set; }

        /// <summary>
        /// 商家地址
        /// </summary>
        [XmlElement("company_address")]
        public AddressBean CompanyAddress { get; set; }

        /// <summary>
        /// 企业代码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 企业代码类型
        /// </summary>
        [XmlElement("company_code_type")]
        public string CompanyCodeType { get; set; }

        /// <summary>
        /// 营业执照名称全称
        /// </summary>
        [XmlElement("company_full_name")]
        public string CompanyFullName { get; set; }

        /// <summary>
        /// 应急联系电话
        /// </summary>
        [XmlElement("emergency_contact_phone")]
        public string EmergencyContactPhone { get; set; }

        /// <summary>
        /// 成立时间
        /// </summary>
        [XmlElement("establishment_date")]
        public string EstablishmentDate { get; set; }

        /// <summary>
        /// 身份证住址
        /// </summary>
        [XmlElement("id_card_address")]
        public string IdCardAddress { get; set; }

        /// <summary>
        /// 身份证反面照（人像面）
        /// </summary>
        [XmlElement("id_card_back_pic")]
        public string IdCardBackPic { get; set; }

        /// <summary>
        /// 身份证有效期结束时间
        /// </summary>
        [XmlElement("id_card_end_date")]
        public string IdCardEndDate { get; set; }

        /// <summary>
        /// 身份证正面照（国徽面）
        /// </summary>
        [XmlElement("id_card_front_pic")]
        public string IdCardFrontPic { get; set; }

        /// <summary>
        /// 身份证有效期开始时间
        /// </summary>
        [XmlElement("id_card_start_date")]
        public string IdCardStartDate { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_person_id_number")]
        public string LegalPersonIdNumber { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 法人手机号
        /// </summary>
        [XmlElement("legal_person_phone")]
        public string LegalPersonPhone { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        [XmlElement("merchant_short_name")]
        public string MerchantShortName { get; set; }

        /// <summary>
        /// 门头照
        /// </summary>
        [XmlElement("out_door_pic")]
        public string OutDoorPic { get; set; }

        /// <summary>
        /// 申请单号，保证唯一，幂等处理
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 根据thirdpay_org定义，现阶段填写huifu_id
        /// </summary>
        [XmlElement("thirdpay_mer_id")]
        public string ThirdpayMerId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("thirdpay_org")]
        public string ThirdpayOrg { get; set; }
    }
}
