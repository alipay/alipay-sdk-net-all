using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeDeviceVO Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeDeviceVO : AopObject
    {
        /// <summary>
        /// 数据插入时间
        /// </summary>
        [XmlElement("add_time")]
        public string AddTime { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备机型id
        /// </summary>
        [XmlElement("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 设备机型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 设备机型编号
        /// </summary>
        [XmlElement("model_no")]
        public string ModelNo { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
