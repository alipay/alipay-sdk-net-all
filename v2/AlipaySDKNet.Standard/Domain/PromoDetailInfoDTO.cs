using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 优惠前置咨询组件返回的优惠活动咨询ID
        /// </summary>
        [XmlElement("activity_consult_id")]
        public string ActivityConsultId { get; set; }
    }
}
