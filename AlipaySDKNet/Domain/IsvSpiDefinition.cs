using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvSpiDefinition Data Structure.
    /// </summary>
    [Serializable]
    public class IsvSpiDefinition : AopObject
    {
        /// <summary>
        /// ISV自定义的标识功能的业务代码，不可重复
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// spi功能描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 功能图标文件url
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// spi接口服务地址
        /// </summary>
        [XmlElement("spi_endpoint")]
        public string SpiEndpoint { get; set; }

        /// <summary>
        /// spi接口扩展参数，json格式字符串
        /// </summary>
        [XmlElement("spi_ext_property")]
        public string SpiExtProperty { get; set; }

        /// <summary>
        /// CCM预先定义的spi key，与插件位置有关
        /// </summary>
        [XmlElement("spi_key")]
        public string SpiKey { get; set; }

        /// <summary>
        /// SPI 名称
        /// </summary>
        [XmlElement("spi_name")]
        public string SpiName { get; set; }
    }
}
