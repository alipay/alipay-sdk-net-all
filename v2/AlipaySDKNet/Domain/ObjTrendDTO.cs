using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjTrendDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ObjTrendDTO : AopObject
    {
        /// <summary>
        /// 个股标识
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 点位详细信息
        /// </summary>
        [XmlArray("trend_list")]
        [XmlArrayItem("trend_d_t_o")]
        public List<TrendDTO> TrendList { get; set; }
    }
}
