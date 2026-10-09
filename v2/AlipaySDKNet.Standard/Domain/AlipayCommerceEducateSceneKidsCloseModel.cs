using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneKidsCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneKidsCloseModel : AopObject
    {
        /// <summary>
        /// 业务场景码。SCHOOL_PAYMENT：校园支付，STUDENT_CARD：电子学生卡
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 扩展参数。（1.当bizCode是SCHOOL_PAYMENT，cert_type,cert_no必传；2.当sub_biz_code是SCHOOL_PAYMENT_FACEPAY，agreement_no必传） （cert_type枚举：1.身份证(IDENTITY_CARD)；2.护照(PASSPORT)；3.学工号(STUDENT_NUMBER)）
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 接口调用id，需保证唯一做幂等
        /// </summary>
        [XmlElement("invoke_id")]
        public string InvokeId { get; set; }

        /// <summary>
        /// 备注，可注明业务场景或特殊说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 刷脸用户openId（当biz_code为SCHOOL_PAYMENT时，当前参数必选）
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于开通一脸通行的支付宝账户openId。如果是父母为孩子开通，则为父母支付宝 openId；如果是用户为本人开通，则为本人支付宝 openId（如果是关闭家长代开通，当前参数必选）
        /// </summary>
        [XmlElement("parent_open_id")]
        public string ParentOpenId { get; set; }

        /// <summary>
        /// 用于开通一脸通行的支付宝账户 uid。如果是父母为孩子开通，则为父母支付宝 uid；如果是用户为本人开通，则为本人支付宝 uid（如果是关闭家长代开通，当前参数必选）
        /// </summary>
        [XmlElement("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 学校外标（当biz_code为SCHOOL_PAYMENT时，当前参数必选）
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 子业务码（当biz_code为SCHOOL_PAYMENT时，当前参数必选）。 {SCHOOL_PAYMENT_ENTRANCE：核身，SCHOOL_PAYMENT_FACEPAY：刷脸支付_代扣， SCHOOL_PAYMENT_FACEPAY_BANK：刷脸支付_ftoken}
        /// </summary>
        [XmlElement("sub_biz_code")]
        public string SubBizCode { get; set; }

        /// <summary>
        /// 刷脸用户id（当biz_code为SCHOOL_PAYMENT时，当前参数必选）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
