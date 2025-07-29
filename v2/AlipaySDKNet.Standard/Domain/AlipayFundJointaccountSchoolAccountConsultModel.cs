using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountSchoolAccountConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountSchoolAccountConsultModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 小荷包开户群主openId，用于查询该用户是否开通小荷包。master_user_id与master_open_id不能同时为空，如果同时传值需保证master_user_id和master_open_id的关联性。
        /// </summary>
        [XmlElement("master_open_id")]
        public string MasterOpenId { get; set; }

        /// <summary>
        /// 小荷包开户群主userId，用于查询该用户是否开通小荷包。master_user_id与master_open_id不能同时为空，如果同时传值需保证master_user_id和master_open_id的关联性。
        /// </summary>
        [XmlElement("master_user_id")]
        public string MasterUserId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 学生证件号，用于验证该学生是否已经加入到指定的小荷包，判断时会验证学生姓名、证件类型、证件号与支付宝侧预留的是否一致
        /// </summary>
        [XmlElement("student_cert_no")]
        public string StudentCertNo { get; set; }

        /// <summary>
        /// 学生证件号，用于验证该学生是否已经加入到指定的小荷包，判断时会验证学生姓名、证件类型、证件号与支付宝侧预留的是否一致
        /// </summary>
        [XmlElement("student_cert_type")]
        public string StudentCertType { get; set; }

        /// <summary>
        /// 学生姓名，用于验证该学生是否已经加入到指定的小荷包，判断时会验证学生姓名、证件类型、证件号与支付宝侧预留的是否一致
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }
    }
}
