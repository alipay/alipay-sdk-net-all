using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmEpBondRatingDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmEpBondRatingDataInfo : AopObject
    {
        /// <summary>
        /// 债券发行列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("zm_ep_bond_rating_info")]
        public List<ZmEpBondRatingInfo> Hits { get; set; }

        /// <summary>
        /// 记录总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
