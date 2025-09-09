using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryDetailPositionVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryDetailPositionVO : AopObject
    {
        /// <summary>
        /// 展位码
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 投放内容透出信息，包含卡片数据，展位码，疲劳度信息
        /// </summary>
        [XmlElement("position_content")]
        public DeliveryDetailPositionContentVO PositionContent { get; set; }
    }
}
