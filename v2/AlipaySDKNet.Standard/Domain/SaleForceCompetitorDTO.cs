using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceCompetitorDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceCompetitorDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("competitor")]
        [XmlArrayItem("string")]
        public List<string> Competitor { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [XmlElement("db_type")]
        public string DbType { get; set; }
    }
}
