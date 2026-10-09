using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyRelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyRelationInfo : AopObject
    {
        /// <summary>
        /// 核准日期
        /// </summary>
        [XmlElement("check_date")]
        public string CheckDate { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企信标识企业唯一ID
        /// </summary>
        [XmlElement("ent_id")]
        public string EntId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 企业状态：在营（开业）、迁出、注销、吊销、撤销登记、撤销、停业
        /// </summary>
        [XmlElement("ent_status")]
        public string EntStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("es_date")]
        public string EsDate { get; set; }

        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        [XmlElement("fr_name")]
        public string FrName { get; set; }

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
        /// 注册币种
        /// </summary>
        [XmlElement("reg_cap_cur")]
        public string RegCapCur { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("rel_type_code")]
        public string RelTypeCode { get; set; }
    }
}
