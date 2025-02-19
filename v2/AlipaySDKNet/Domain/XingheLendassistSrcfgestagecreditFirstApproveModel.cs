using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistSrcfgestagecreditFirstApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistSrcfgestagecreditFirstApproveModel : AopObject
    {
        /// <summary>
        /// 政企客户经理所属市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 政企客客户经理身份证号
        /// </summary>
        [XmlElement("cust_manager_id_card")]
        public string CustManagerIdCard { get; set; }

        /// <summary>
        /// 政企客户经理姓名
        /// </summary>
        [XmlElement("cust_manager_name")]
        public string CustManagerName { get; set; }

        /// <summary>
        /// 政企客户经理所属区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 员工政企单位统一社会信用代码
        /// </summary>
        [XmlElement("gov_enter_cert_no")]
        public string GovEnterCertNo { get; set; }

        /// <summary>
        /// 员工政企单位名称
        /// </summary>
        [XmlElement("gov_enter_name")]
        public string GovEnterName { get; set; }

        /// <summary>
        /// 平台为接入客户分配
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 员工是否为领导标识，NOT_LEADER-不是领导 、LEADER-是领导
        /// </summary>
        [XmlElement("leader_flag")]
        public string LeaderFlag { get; set; }

        /// <summary>
        /// 客户经理所属运营商
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 政企客户经理所属公司名称
        /// </summary>
        [XmlElement("operator_company")]
        public string OperatorCompany { get; set; }

        /// <summary>
        /// 唯一标识政企员工团购分期授信请求
        /// </summary>
        [XmlElement("out_bsn_no")]
        public string OutBsnNo { get; set; }

        /// <summary>
        /// 业务所属产品，平台为业务分配
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 政企客户经理所属省
        /// </summary>
        [XmlElement("provincial")]
        public string Provincial { get; set; }

        /// <summary>
        /// 上传接口上传社保图片成功后返回的文件id
        /// </summary>
        [XmlElement("social_security_image_id")]
        public string SocialSecurityImageId { get; set; }

        /// <summary>
        /// 政企员工的身份证号
        /// </summary>
        [XmlElement("user_id_card")]
        public string UserIdCard { get; set; }

        /// <summary>
        /// 政企员工的姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 政企员工名下手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
