using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetInfo : AopObject
    {
        /// <summary>
        /// 资产ID
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户开放ID
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
