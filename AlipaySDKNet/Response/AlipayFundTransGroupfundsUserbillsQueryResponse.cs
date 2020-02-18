using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransGroupfundsUserbillsQueryResponse.
    /// </summary>
    public class AlipayFundTransGroupfundsUserbillsQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前用户涉及的流水模型列表，仅返回实际存在的流水数据
        /// </summary>
        [XmlElement("user_bills")]
        public GroupFundUserBill UserBills { get; set; }
    }
}
