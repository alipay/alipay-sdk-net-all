using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCoOverviewInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCoOverviewInfo : AopObject
    {
        /// <summary>
        /// 集团实际控制方统一社会信用代码
        /// </summary>
        [XmlElement("crn")]
        public string Crn { get; set; }

        /// <summary>
        /// 行业分布
        /// </summary>
        [XmlElement("industry")]
        public IndustryCountInfo Industry { get; set; }

        /// <summary>
        /// 集团参股认缴额总和（万元）
        /// </summary>
        [XmlElement("inv_amount")]
        public string InvAmount { get; set; }

        /// <summary>
        /// 集团参股数量
        /// </summary>
        [XmlElement("inv_num")]
        public long InvNum { get; set; }

        /// <summary>
        /// 集团成员数量
        /// </summary>
        [XmlElement("member_num")]
        public long MemberNum { get; set; }

        /// <summary>
        /// 集团成员注册资本总和（万元）
        /// </summary>
        [XmlElement("member_registered_capital")]
        public string MemberRegisteredCapital { get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地区分布
        /// </summary>
        [XmlElement("province")]
        public CityCountInfo Province { get; set; }

        /// <summary>
        /// 集团实际控制方企业名称
        /// </summary>
        [XmlElement("root")]
        public string Root { get; set; }
    }
}
