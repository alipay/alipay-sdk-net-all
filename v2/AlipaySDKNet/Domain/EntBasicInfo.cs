using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EntBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EntBasicInfo : AopObject
    {
        /// <summary>
        /// 企业注册地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 企业核准日期
        /// </summary>
        [XmlElement("appr_date")]
        public string ApprDate { get; set; }

        /// <summary>
        /// 经营状态为注销时，此数据才有值
        /// </summary>
        [XmlElement("cancel_date")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 企业经营状态：在营（开业）、迁出、注销、吊销、撤销登记、撤销、停业、其他
        /// </summary>
        [XmlElement("ent_status")]
        public string EntStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

        /// <summary>
        /// 企业开业日期
        /// </summary>
        [XmlElement("es_date")]
        public string EsDate { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("fr_name")]
        public string FrName { get; set; }

        /// <summary>
        /// 国民经济行业代码
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 国民经济行业名称
        /// </summary>
        [XmlElement("industry_name")]
        public string IndustryName { get; set; }

        /// <summary>
        /// 国民经济行业门类代码
        /// </summary>
        [XmlElement("industry_phy_code")]
        public string IndustryPhyCode { get; set; }

        /// <summary>
        /// 国民经济行业门类名称
        /// </summary>
        [XmlElement("industry_phy_name")]
        public string IndustryPhyName { get; set; }

        /// <summary>
        /// 企业营业期限开始日期
        /// </summary>
        [XmlElement("open_from")]
        public string OpenFrom { get; set; }

        /// <summary>
        /// 企业营业期限结束日期，其中永久为999-09-09
        /// </summary>
        [XmlElement("open_to")]
        public string OpenTo { get; set; }

        /// <summary>
        /// 企业经营范围
        /// </summary>
        [XmlElement("operate_scope")]
        public string OperateScope { get; set; }

        /// <summary>
        /// 注册资本，单位是万元
        /// </summary>
        [XmlElement("reg_cap")]
        public string RegCap { get; set; }

        /// <summary>
        /// 注册币种
        /// </summary>
        [XmlElement("reg_cap_cur")]
        public string RegCapCur { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 企业登记机关
        /// </summary>
        [XmlElement("reg_org")]
        public string RegOrg { get; set; }

        /// <summary>
        /// 企业经营状态为吊销时，此数据才有值
        /// </summary>
        [XmlElement("revoke_date")]
        public string RevokeDate { get; set; }
    }
}
