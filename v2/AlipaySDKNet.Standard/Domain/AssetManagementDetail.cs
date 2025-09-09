using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetManagementDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetManagementDetail : AopObject
    {
        /// <summary>
        /// 校验名称
        /// </summary>
        [XmlElement("check_name")]
        public string CheckName { get; set; }

        /// <summary>
        /// 校验类型
        /// </summary>
        [XmlElement("check_type")]
        public string CheckType { get; set; }

        /// <summary>
        /// 需求阶段
        /// </summary>
        [XmlElement("require_phase")]
        public string RequirePhase { get; set; }

        /// <summary>
        /// 需求资源
        /// </summary>
        [XmlElement("require_resource")]
        public string RequireResource { get; set; }
    }
}
