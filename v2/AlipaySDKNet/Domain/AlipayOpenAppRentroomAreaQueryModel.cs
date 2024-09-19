using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentroomAreaQueryModel : AopObject
    {
        /// <summary>
        /// 小区ID，通过租房小区信息提报接口返参获取
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 商户侧对应的小区唯一编码，由商户自定义
        /// </summary>
        [XmlElement("out_area_id")]
        public string OutAreaId { get; set; }
    }
}
