using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetSupplyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetSupplyDetail : AopObject
    {
        /// <summary>
        /// 作业模式
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 组包方式
        /// </summary>
        [XmlElement("assemble_type")]
        public string AssembleType { get; set; }

        /// <summary>
        /// 物料管控详细信息
        /// </summary>
        [XmlArray("management_details")]
        [XmlArrayItem("asset_management_detail")]
        public List<AssetManagementDetail> ManagementDetails { get; set; }
    }
}
