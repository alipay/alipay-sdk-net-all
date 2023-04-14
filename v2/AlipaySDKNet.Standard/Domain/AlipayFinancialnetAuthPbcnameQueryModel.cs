using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcnameQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthPbcnameQueryModel : AopObject
    {
        /// <summary>
        /// 联行号数据
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 分支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 城市信息
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 是否精确匹配
        /// </summary>
        [XmlElement("exact")]
        public bool Exact { get; set; }

        /// <summary>
        /// 顶级机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 顶级机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 省份信息
        /// </summary>
        [XmlElement("provice")]
        public string Provice { get; set; }
    }
}
