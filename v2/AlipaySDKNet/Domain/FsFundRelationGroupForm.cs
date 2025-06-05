using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FsFundRelationGroupForm Data Structure.
    /// </summary>
    [Serializable]
    public class FsFundRelationGroupForm : AopObject
    {
        /// <summary>
        /// 出资明细
        /// </summary>
        [XmlArray("fund_relation_details")]
        [XmlArrayItem("fs_fund_relation_detail_form")]
        public List<FsFundRelationDetailForm> FundRelationDetails { get; set; }

        /// <summary>
        /// 出资策略：RATIO
        /// </summary>
        [XmlElement("fund_strategy")]
        public string FundStrategy { get; set; }
    }
}
