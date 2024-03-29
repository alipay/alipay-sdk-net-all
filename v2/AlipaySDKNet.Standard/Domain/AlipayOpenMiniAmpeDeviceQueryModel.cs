using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDeviceQueryModel : AopObject
    {
        /// <summary>
        /// 设备id，选填
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机型ID，必填
        /// </summary>
        [XmlElement("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 当前页，选填，默认值为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，选填，默认值10, 最大值为100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 产品ID，必填
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
