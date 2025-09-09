using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeDeviceInfo : AopObject
    {
        /// <summary>
        /// 支付宝卡片的高度，单位：像素
        /// </summary>
        [XmlElement("card_height")]
        public long CardHeight { get; set; }

        /// <summary>
        /// 支付宝卡片的宽度，单位：像素
        /// </summary>
        [XmlElement("card_width")]
        public long CardWidth { get; set; }
    }
}
