using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvBalanceQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 管控账户的余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 查询账户状态的说明
        /// </summary>
        [XmlElement("mark")]
        public string Mark { get; set; }

        /// <summary>
        /// 账户冻结余额查询状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
