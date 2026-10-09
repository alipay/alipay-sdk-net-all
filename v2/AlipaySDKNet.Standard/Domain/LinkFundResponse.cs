using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkFundResponse Data Structure.
    /// </summary>
    [Serializable]
    public class LinkFundResponse : AopObject
    {
        /// <summary>
        /// 基金类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 关联的基金列表
        /// </summary>
        [XmlArray("link_funds")]
        [XmlArrayItem("link_fund_result")]
        public List<LinkFundResult> LinkFunds { get; set; }
    }
}
