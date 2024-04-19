using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthPbcQueryResponse : AopResponse
    {
        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 城市信息
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

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

        /// <summary>
        /// 承接的清算机构
        /// </summary>
        [XmlElement("undertake_inst")]
        public string UndertakeInst { get; set; }
    }
}
