using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HealthCardInfo : AopObject
    {
        /// <summary>
        /// 用户真实健康卡数据信息
        /// </summary>
        [XmlArray("cards")]
        [XmlArrayItem("health_card")]
        public List<HealthCard> Cards { get; set; }

        /// <summary>
        /// 支付宝内用户健康卡领取跳转地址链接，仅在用户没有健康卡数据是返回
        /// </summary>
        [XmlElement("receive_url")]
        public string ReceiveUrl { get; set; }
    }
}
