using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdOrderQueryModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放订单对应的外部资源ID
        /// </summary>
        [XmlElement("order_outer_id")]
        public string OrderOuterId { get; set; }
    }
}
