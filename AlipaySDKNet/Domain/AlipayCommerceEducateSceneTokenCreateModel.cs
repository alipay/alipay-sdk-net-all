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
        /// 1:身份证  2:军官证  3:士兵证  8:台湾居民通行证  A:护照  B:户口簿  Z:其它证件
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 采集人员的支付宝会员标识
        /// </summary>
        [XmlElement("operator_user_id")]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 家长手机号码
        /// </summary>
        [XmlElement("parent_phone")]
        public string ParentPhone { get; set; }

        /// <summary>
        /// 学校外标（即学校的统一信用编码）
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学生姓名
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
