using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetItemVersionFeedBackInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetItemVersionFeedBackInfo : AopObject
    {
        /// <summary>
        /// 物料ID信息
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料版本号
        /// </summary>
        [XmlElement("item_version")]
        public long ItemVersion { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否可供应
        /// </summary>
        [XmlElement("suppliable")]
        public string Suppliable { get; set; }
    }
}
