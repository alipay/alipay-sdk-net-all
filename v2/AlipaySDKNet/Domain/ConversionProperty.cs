using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConversionProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ConversionProperty : AopObject
    {
        /// <summary>
        /// 业务转化数据属性
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 转化属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务转化属性实例值， property_list的value值需与转化管理里创建转化事件时填写的归因口径值保持一致<br> attrbute_list的value值请参考该文档：<a href='https://adpub.alipay.com/adrlark/ivdktpyh511x9r6i'>转化事件类型属性规则</a>
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
