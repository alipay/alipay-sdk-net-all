using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDevicemodelModifyModel : AopObject
    {
        /// <summary>
        /// 硬件参数，选填，三选一，最大长度30
        /// </summary>
        [XmlElement("hardware_params")]
        public string HardwareParams { get; set; }

        /// <summary>
        /// 机型ID，必填
        /// </summary>
        [XmlElement("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 机型名称，选填，三选一，最大长度30，单productId下唯一
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 机型编号，选填，三选一，最大长度30，单productId下唯一
        /// </summary>
        [XmlElement("model_no")]
        public string ModelNo { get; set; }

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
