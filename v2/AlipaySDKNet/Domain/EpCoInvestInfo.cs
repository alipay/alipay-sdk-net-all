using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCoInvestInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCoInvestInfo : AopObject
    {
        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("build_date")]
        public string BuildDate { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("crn")]
        public string Crn { get; set; }

        /// <summary>
        /// 直接持股占比
        /// </summary>
        [XmlElement("direct_ratio")]
        public string DirectRatio { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("legal_representative")]
        public string LegalRepresentative { get; set; }

        /// <summary>
        /// 投资方式
        /// </summary>
        [XmlArray("means")]
        [XmlArrayItem("string")]
        public List<string> Means { get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 间接持股详情
        /// </summary>
        [XmlArray("ratio")]
        [XmlArrayItem("ep_ratio_info")]
        public List<EpRatioInfo> Ratio { get; set; }

        /// <summary>
        /// 带币种的注册资本
        /// </summary>
        [XmlElement("register_capital")]
        public string RegisterCapital { get; set; }

        /// <summary>
        /// 注册资本（单位万元）
        /// </summary>
        [XmlElement("register_capital_text")]
        public string RegisterCapitalText { get; set; }
    }
}
