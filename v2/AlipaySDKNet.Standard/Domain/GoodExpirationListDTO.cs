using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodExpirationListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodExpirationListDTO : AopObject
    {
        /// <summary>
        /// 商品有效时长，单位:天，有临期食品时可填写，非必填。
        /// </summary>
        [XmlElement("good_effective_duration")]
        public long GoodEffectiveDuration { get; set; }

        /// <summary>
        /// 商品有效截止时间(商品过期时间)，有临期食品时可填写，非必填。时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("good_expiration_time")]
        public string GoodExpirationTime { get; set; }

        /// <summary>
        /// 商品生产时间，有临期食品时可填写，非必填。时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("good_prd_time")]
        public string GoodPrdTime { get; set; }
    }
}
