using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardItemOfflineModel : AopObject
    {
        /// <summary>
        /// 次卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
