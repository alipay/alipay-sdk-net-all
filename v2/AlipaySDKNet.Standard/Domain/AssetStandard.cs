using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetStandard Data Structure.
    /// </summary>
    [Serializable]
    public class AssetStandard : AopObject
    {
        /// <summary>
        /// 生产资料标准大字段
        /// </summary>
        [XmlElement("pm_std")]
        public string PmStd { get; set; }
    }
}
