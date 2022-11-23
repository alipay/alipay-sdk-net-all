using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneTokenQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务场景类型标识
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 刷脸用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户外部ID。（服务商内部唯一ID，唯一关联一位学生/教职工)
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 家长支付宝账户的脱敏信息（特例：特殊标识"ALREADY_RELEASED"，须通过技术支持反馈来关闭开通记录）
        /// </summary>
        [XmlElement("parent_logon_id")]
        public string ParentLogonId { get; set; }

        /// <summary>
        /// 如果是父母为孩子开通，则为父母支付宝openid；如果是用户为本人开通，则为本人支付宝openid。
        /// </summary>
        [XmlElement("parent_open_id")]
        public string ParentOpenId { get; set; }

        /// <summary>
        /// 如果是父母为孩子开通，则为父母支付宝uid；如果是用户为本人开通，则为本人支付宝uid。
        /// </summary>
        [XmlElement("parent_user_id")]
        public string ParentUserId { get; set; }

        /// <summary>
        /// 用户已签约的 PID 列表
        /// </summary>
        [XmlArray("payment_pid_list")]
        [XmlArrayItem("string")]
        public List<string> PaymentPidList { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 校园一脸通行开通状态
        /// </summary>
        [XmlElement("school_face_pass_status")]
        public string SchoolFacePassStatus { get; set; }

        /// <summary>
        /// 校园一脸通行刷脸支付开通状态
        /// </summary>
        [XmlElement("school_face_payment_status")]
        public string SchoolFacePaymentStatus { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 刷脸用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
