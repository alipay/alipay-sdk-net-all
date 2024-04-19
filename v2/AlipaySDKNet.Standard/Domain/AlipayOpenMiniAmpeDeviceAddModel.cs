using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDeviceAddModel : AopObject
    {
        /// <summary>
        /// 用于标识厂商单个设备产品下唯一的一个设备，推荐使用厂商自己定义的序列号。单次最多提交200个，如果productId下已存在deviceId，会被更新为最新一次提交的数据
        /// </summary>
        [XmlArray("device_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceIdList { get; set; }

        /// <summary>
        /// 设备产品下具体的一个机型ID，由系统生成
        /// </summary>
        [XmlElement("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 设备产品的productId，由系统生成
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
