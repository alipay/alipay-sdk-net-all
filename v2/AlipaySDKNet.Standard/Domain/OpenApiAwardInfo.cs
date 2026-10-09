using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiAwardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiAwardInfo : AopObject
    {
        /// <summary>
        /// 奖品当前数额
        /// </summary>
        [XmlElement("current_award")]
        public string CurrentAward { get; set; }

        /// <summary>
        /// 奖项详情
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("string")]
        public List<string> DetailList { get; set; }

        /// <summary>
        /// 奖品总计数额
        /// </summary>
        [XmlElement("total_award")]
        public string TotalAward { get; set; }
    }
}
