using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetBomQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetBomQueryModel : AopObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
