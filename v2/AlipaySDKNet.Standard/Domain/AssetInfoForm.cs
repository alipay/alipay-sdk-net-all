using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetInfoForm Data Structure.
    /// </summary>
    [Serializable]
    public class AssetInfoForm : AopObject
    {
        /// <summary>
        /// 资产ID，必传
        /// </summary>
        [XmlElement("asset_no")]
        public string AssetNo { get; set; }

        /// <summary>
        /// asset_no对应的资产类型，必填
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }
    }
}
