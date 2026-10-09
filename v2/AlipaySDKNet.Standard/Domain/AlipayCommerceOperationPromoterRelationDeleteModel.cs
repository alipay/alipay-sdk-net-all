using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoterRelationDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoterRelationDeleteModel : AopObject
    {
        /// <summary>
        /// 需要解除的门店对映的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 海鼎门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 店员id，需要解除的导购员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
