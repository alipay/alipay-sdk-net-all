using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpContactComplextInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpContactComplextInfo : AopObject
    {
        /// <summary>
        /// 企业18位统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 企业状态
        /// </summary>
        [XmlElement("ent_status")]
        public string EntStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

        /// <summary>
        /// 企业联系方式列表
        /// </summary>
        [XmlArray("ep_contact_info")]
        [XmlArrayItem("ep_contact_base_info")]
        public List<EpContactBaseInfo> EpContactInfo { get; set; }

        /// <summary>
        /// 成立日期（yy-MM-dd）
        /// </summary>
        [XmlElement("es_date")]
        public string EsDate { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("fr_name")]
        public string FrName { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("oprt_scope")]
        public string OprtScope { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("reg_addr")]
        public string RegAddr { get; set; }

        /// <summary>
        /// 注册资本(万元）
        /// </summary>
        [XmlElement("reg_cap")]
        public string RegCap { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("reg_org")]
        public string RegOrg { get; set; }
    }
}
