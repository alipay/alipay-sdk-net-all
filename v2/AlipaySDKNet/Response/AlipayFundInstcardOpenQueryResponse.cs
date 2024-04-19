using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundInstcardOpenQueryResponse.
    /// </summary>
    public class AlipayFundInstcardOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开户机构名
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
