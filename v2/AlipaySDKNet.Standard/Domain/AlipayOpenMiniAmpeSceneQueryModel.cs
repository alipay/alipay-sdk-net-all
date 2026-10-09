using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeSceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeSceneQueryModel : AopObject
    {
        /// <summary>
        /// 设备产品的productId，由系统生成
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
