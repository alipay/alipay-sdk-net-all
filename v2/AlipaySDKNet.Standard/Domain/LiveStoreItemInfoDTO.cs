using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveStoreItemInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LiveStoreItemInfoDTO : AopObject
    {
        /// <summary>
        /// 控货结果
        /// </summary>
        [XmlElement("check_result")]
        public OpenContentGoodsCheckResult CheckResult { get; set; }

        /// <summary>
        /// 商品是否在带货车，true表示在带货车，false表示不在
        /// </summary>
        [XmlElement("in_store")]
        public bool InStore { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
