using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetFundDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AssetFundDTO : AopObject
    {
        /// <summary>
        /// 资产数额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }
    }
}
