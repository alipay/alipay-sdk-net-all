using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpFundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VcpFundInfo : AopObject
    {
        /// <summary>
        /// 出资账号
        /// </summary>
        [XmlElement("display_account")]
        public string DisplayAccount { get; set; }

        /// <summary>
        /// 资金账号
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 出资类型，如资金池（FUND_SCHEME）、余额（BALANCE）
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }
    }
}
