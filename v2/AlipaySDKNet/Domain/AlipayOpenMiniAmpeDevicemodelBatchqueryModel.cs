using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDevicemodelBatchqueryModel : AopObject
    {
        /// <summary>
        /// 产品ID，必填
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
