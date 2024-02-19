using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetReverseSupplierApplyExpressSnDetails Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseSupplierApplyExpressSnDetails : AopObject
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_infos")]
        public LogisticsInfo LogisticsInfos { get; set; }

        /// <summary>
        /// sn列表
        /// </summary>
        [XmlArray("sn_records")]
        [XmlArrayItem("string")]
        public List<string> SnRecords { get; set; }
    }
}
