using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeDeviceModelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeDeviceModelInfo : AopObject
    {
        /// <summary>
        /// 硬件参数
        /// </summary>
        [XmlElement("hardware_params")]
        public string HardwareParams { get; set; }

        /// <summary>
        /// 机型id
        /// </summary>
        [XmlElement("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 机型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 机型编号
        /// </summary>
        [XmlElement("model_no")]
        public string ModelNo { get; set; }
    }
}
