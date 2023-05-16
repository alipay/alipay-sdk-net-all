using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryPositionVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPositionVO : AopObject
    {
        /// <summary>
        /// 投放展位展位代码
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 投放展位内容列表
        /// </summary>
        [XmlArray("position_content")]
        [XmlArrayItem("delivery_position_content_v_o")]
        public List<DeliveryPositionContentVO> PositionContent { get; set; }
    }
}
