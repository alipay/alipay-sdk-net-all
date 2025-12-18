using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletMerchantChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WalletMerchantChargeInfo : AopObject
    {
        /// <summary>
        /// 收费场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
