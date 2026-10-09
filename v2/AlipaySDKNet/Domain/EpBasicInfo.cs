using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpBasicInfo : AopObject
    {
        /// <summary>
        /// 公司地址
        /// </summary>
        [XmlElement("ep_address")]
        public string EpAddress { get; set; }

        /// <summary>
        /// 核准日期
        /// </summary>
        [XmlElement("ep_appr_date")]
        public string EpApprDate { get; set; }

        /// <summary>
        /// 企业社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 营业期至
        /// </summary>
        [XmlElement("ep_open_to")]
        public string EpOpenTo { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("ep_operate_scope")]
        public string EpOperateScope { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("ep_reg_captial")]
        public string EpRegCaptial { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("ep_reg_no")]
        public string EpRegNo { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("ep_reg_org")]
        public string EpRegOrg { get; set; }

        /// <summary>
        /// 企业经营状态
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 企业主体类型
        /// </summary>
        [XmlElement("ep_type")]
        public string EpType { get; set; }

        /// <summary>
        /// 公司成立日期
        /// </summary>
        [XmlElement("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 企业信用生成的唯一企业ID
        /// </summary>
        [XmlElement("one_id")]
        public string OneId { get; set; }
    }
}
