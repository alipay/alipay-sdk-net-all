using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDeviceDeleteModel : AopObject
    {
        /// <summary>
        /// 厂商在对应设备产品和机型下已添加的设备ID，单次最多提交200个
        /// </summary>
        [XmlArray("device_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceIdList { get; set; }

        /// <summary>
        /// 设备产品下具体的一个机型ID，由系统生成
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备产品的productId，由系统生成
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
