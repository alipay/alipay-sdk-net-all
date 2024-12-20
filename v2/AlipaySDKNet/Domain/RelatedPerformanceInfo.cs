using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelatedPerformanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RelatedPerformanceInfo : AopObject
    {
        /// <summary>
        /// 注册所在地
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 经营状态为注销时，此数据才有值
        /// </summary>
        [XmlElement("cancel_date")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 注册所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 出资方式-股东信息有值
        /// </summary>
        [XmlElement("con_form")]
        public string ConForm { get; set; }

        /// <summary>
        /// 注册所在区县
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 认缴出资币种-股东信息有值
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 企信唯一标识企业one_id
        /// </summary>
        [XmlElement("ent_id")]
        public string EntId { get; set; }

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
        /// 成立日期
        /// </summary>
        [XmlElement("es_date")]
        public string EsDate { get; set; }

        /// <summary>
        /// 认缴出资比例-股东信息有值
        /// </summary>
        [XmlElement("funde_ratio")]
        public string FundeRatio { get; set; }

        /// <summary>
        /// 认缴出资比例-股东信息有值
        /// </summary>
        [XmlElement("funded_ratio")]
        public string FundedRatio { get; set; }

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
        /// 职务
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }

        /// <summary>
        /// 注册所在省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 注册资本（万元）
        /// </summary>
        [XmlElement("reg_cap")]
        public string RegCap { get; set; }

        /// <summary>
        /// 注册币种
        /// </summary>
        [XmlElement("reg_cap_cur")]
        public string RegCapCur { get; set; }

        /// <summary>
        /// 注册地所在城市区域代码
        /// </summary>
        [XmlElement("reg_city")]
        public string RegCity { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 企业经营状态为吊销时，此数据才有值
        /// </summary>
        [XmlElement("revoke_date")]
        public string RevokeDate { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("ry_name")]
        public string RyName { get; set; }

        /// <summary>
        /// 认缴出资额(万元)-股东信息有值
        /// </summary>
        [XmlElement("sub_conam")]
        public string SubConam { get; set; }
    }
}
