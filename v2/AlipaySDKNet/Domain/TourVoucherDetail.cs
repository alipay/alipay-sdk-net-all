using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourVoucherDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TourVoucherDetail : AopObject
    {
        /// <summary>
        /// 游客证件号码。一码通场景，凭证状态未使用时，证件号与手机号二选一必填。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，传入证件号的同时需要传入证件类型，不传默认填充身份证。 身份证：IDENTITY_CARD 护照：PASSPORT 港澳居民通行证：HOME_VISIT_PERMIT_HK_MC 台湾居民通行证：HOME_VISIT_PERMIT_TAIWAN 港澳居民居住证：RESIDENCE_PERMIT_HK_MC 台湾居民居住证：RESIDENCE_PERMIT_TAIWAN 外国人永久居留证：PERMANENT_RESIDENCE_FOREIGNER
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 码信息。 一码通场景必填，碰一下场景可空。 codeToken可从扫码的码协议中获取，且一码通场景该字段必填。
        /// </summary>
        [XmlElement("code_info")]
        public string CodeInfo { get; set; }

        /// <summary>
        /// 用于自定义门票适用人群的标识名称，如“学生票”“老人票”“优待票”等，可根据实际需求自由填写，便于用户快速识别适用对象。
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 特殊人群。即凭证所适用的人群类型，比如：学生票，教师票，老人票等等。当该凭证为特殊人群凭证时必须填写，不填写时默认该凭证为普通成人票，枚举值详见对接文档。
        /// </summary>
        [XmlArray("identity_type")]
        [XmlArrayItem("string")]
        public List<string> IdentityType { get; set; }

        /// <summary>
        /// 游客姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 已废弃 当前字段已废弃(字段所用场景业务已废弃)
        /// </summary>
        [XmlElement("out_vercher_id")]
        public string OutVercherId { get; set; }

        /// <summary>
        /// 凭证号，请保证凭证号唯一。
        /// </summary>
        [XmlElement("out_voucher_id")]
        public string OutVoucherId { get; set; }

        /// <summary>
        /// 支付宝景点id。一码通场景必填。如果是多个景区，则以逗号形式分隔id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 可核销次数。如果无限次，则填MAX
        /// </summary>
        [XmlElement("source_num")]
        public string SourceNum { get; set; }

        /// <summary>
        /// 凭证状态。 UNUSED-待使用。 USED-已使用（已核销） REFUNDED-已退款
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 游客手机号。一码通场景，凭证状态未使用时，证件号与手机号二选一必填。
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }

        /// <summary>
        /// 【门票核销方式】当凭证状态为「部分核销」或「已核销」时填写。
        /// </summary>
        [XmlElement("verify_method")]
        public string VerifyMethod { get; set; }

        /// <summary>
        /// 凭证核销用户的openId，当凭证为核销状态时必传
        /// </summary>
        [XmlElement("verify_open_id")]
        public string VerifyOpenId { get; set; }

        /// <summary>
        /// 核销用户的支付宝账户ID。凭证为核销状态时，此字段必须填写
        /// </summary>
        [XmlElement("verify_user_id")]
        public string VerifyUserId { get; set; }

        /// <summary>
        /// 凭证详情信息。 startTime和endTime代表凭证的起止日期，必填。 verifyTime：核销时间。当凭证为核销状态时必须填写该字段。 voucherName：凭证名称/票名称，必填
        /// </summary>
        [XmlElement("voucher_info")]
        public string VoucherInfo { get; set; }
    }
}
