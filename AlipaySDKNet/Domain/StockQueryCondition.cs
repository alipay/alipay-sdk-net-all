using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StockQueryCondition Data Structure.
    /// </summary>
    [Serializable]
    public class StockQueryCondition : AopObject
    {
        /// <summary>
        /// 库存查询结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 站点列表
        /// </summary>
        [XmlArray("position")]
        [XmlArrayItem("position")]
        public List<Position> Position { get; set; }

        /// <summary>
        /// 库存查询起始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
