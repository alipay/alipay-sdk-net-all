using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFunditemGetResponse.
    /// </summary>
    public class AlipayUserFunditemGetResponse : AopResponse
    {
        /// <summary>
        /// 查询得到的消费记录详细信息（主记录+资金明细列表）
        /// </summary>
        [XmlElement("fund_detail_item_aopmodel")]
        public FundDetailItemAOPModel FundDetailItemAopmodel { get; set; }
    }
}
