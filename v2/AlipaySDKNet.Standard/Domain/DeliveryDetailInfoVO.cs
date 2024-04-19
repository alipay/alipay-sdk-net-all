using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryDetailInfoVO : AopObject
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlArray("delivery_list")]
        [XmlArrayItem("delivery_info_v_o")]
        public List<DeliveryInfoVO> DeliveryList { get; set; }

        /// <summary>
        /// 发货完成标志位，false:未发完  ， true:已发完
        /// </summary>
        [XmlElement("finish_all_delivery")]
        public string FinishAllDelivery { get; set; }
    }
}
