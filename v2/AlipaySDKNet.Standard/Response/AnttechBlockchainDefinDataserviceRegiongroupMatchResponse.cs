using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceRegiongroupMatchResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceRegiongroupMatchResponse : AopResponse
    {
        /// <summary>
        /// 匹配条件的区块分组编码列表
        /// </summary>
        [XmlArray("region_group_codes")]
        [XmlArrayItem("string")]
        public List<string> RegionGroupCodes { get; set; }

        /// <summary>
        /// 玉米区块编组匹配数
        /// </summary>
        [XmlElement("region_group_count_101")]
        public long RegionGroupCount101 { get; set; }

        /// <summary>
        /// 大豆区块编组匹配数
        /// </summary>
        [XmlElement("region_group_count_115")]
        public long RegionGroupCount115 { get; set; }

        /// <summary>
        /// 水稻区块编组匹配数
        /// </summary>
        [XmlElement("region_group_count_147")]
        public long RegionGroupCount147 { get; set; }
    }
}
