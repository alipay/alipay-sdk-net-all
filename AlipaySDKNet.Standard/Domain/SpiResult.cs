using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpiResult Data Structure.
    /// </summary>
    [Serializable]
    public class SpiResult : AopObject
    {
        /// <summary>
        /// isv自定义业务代码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// spi唯一id
        /// </summary>
        [XmlElement("spi_id")]
        public long SpiId { get; set; }
    }
}
