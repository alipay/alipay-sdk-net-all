using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceKidsRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceKidsRelationQueryModel : AopObject
    {
        /// <summary>
        /// 家长支付宝userId，用于查询与该家长关联的孩子
        /// </summary>
        [XmlElement("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 场景码，接入前需要进行申请,如：PHILANTHROPY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，需要提前沟通，如：XB_SELECT
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
