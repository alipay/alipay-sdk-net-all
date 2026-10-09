using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferBalanceQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额列表
        /// </summary>
        [XmlArray("balances")]
        [XmlArrayItem("money")]
        public List<Money> Balances { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
