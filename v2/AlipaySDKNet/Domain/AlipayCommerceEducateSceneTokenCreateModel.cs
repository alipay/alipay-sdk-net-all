using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneTokenCreateModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。{1:居民身份证；A:护照；X:学工号}
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 采集人员的支付宝openId。（当sub_code为SCHOOL_PAYMENT_REMOTE_OPEN_ACCOUNT时，当前参数必选）
        /// </summary>
        [XmlElement("operator_open_id")]
        public string OperatorOpenId { get; set; }

        /// <summary>
        /// 采集人员的支付宝会员标识。（当sub_code为SCHOOL_PAYMENT_REMOTE_OPEN_ACCOUNT时，当前参数必选）
        /// </summary>
        [XmlElement("operator_user_id")]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 服务商内部唯一ID，升级token模式后必须提供，默认可以不填
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 家长手机号码。
        /// </summary>
        [XmlElement("parent_phone")]
        public string ParentPhone { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学生/教职工/访客姓名
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 教育场景子业务。SCHOOL_PAYMENT_REMOTE_OPEN_ACCOUNT：校园一脸通行集采邀请（生成的token用于集采邀请发送采集阶段）； SCHOOL_FACE_PASS_QUERY：校园一脸通行查询（生成的token用于查询同学的一脸通行开通状态）； SCHOOL_FACE_PASS_NAVIGATE：校园一脸通行跳转（生成的token用于个采开通阶段的用户信息填充）；
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }
    }
}
