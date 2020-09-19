using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeProductModifyModel : AopObject
    {
        /// <summary>
        /// 产品id，必填
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 设备产品名称, 必填，最大长度32，单oid下唯一
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
