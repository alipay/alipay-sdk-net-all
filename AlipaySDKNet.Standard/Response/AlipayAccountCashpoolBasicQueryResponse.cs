using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountCashpoolBasicQueryResponse.
    /// </summary>
    public class AlipayAccountCashpoolBasicQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金池总数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 资金池基本信息查询结果
        /// </summary>
        [XmlArray("inst_basic_cash_pool_list")]
        [XmlArrayItem("string")]
        public List<string> InstBasicCashPoolList { get; set; }
    }
}
