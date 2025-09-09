using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpSpuGeneralInfoResult Data Structure.
    /// </summary>
    [Serializable]
    public class EpSpuGeneralInfoResult : AopObject
    {
        /// <summary>
        /// 经营类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

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
        /// 登记状态
        /// </summary>
        [XmlElement("ent_status")]
        public string EntStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

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
        /// 注册资本（单位：万元）
        /// </summary>
        [XmlElement("reg_cap")]
        public string RegCap { get; set; }

        /// <summary>
        /// 企业15位注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("reg_org")]
        public string RegOrg { get; set; }

        /// <summary>
        /// 企业产品列表
        /// </summary>
        [XmlArray("spu_list")]
        [XmlArrayItem("ep_spu_general_info")]
        public List<EpSpuGeneralInfo> SpuList { get; set; }
    }
}
