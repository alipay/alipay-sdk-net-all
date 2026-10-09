using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FsFundRelationGroupDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FsFundRelationGroupDTO : AopObject
    {
        /// <summary>
        /// 出资关系明细列表
        /// </summary>
        [XmlArray("fund_relation_details")]
        [XmlArrayItem("fs_fund_relation_detail_d_t_o")]
        public List<FsFundRelationDetailDTO> FundRelationDetails { get; set; }

        /// <summary>
        /// 按照出资比例出资
        /// </summary>
        [XmlElement("fund_strategy")]
        public string FundStrategy { get; set; }

        /// <summary>
        /// 出资组ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
