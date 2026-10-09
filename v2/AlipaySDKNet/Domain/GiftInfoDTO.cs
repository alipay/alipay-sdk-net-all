using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GiftInfoDTO : AopObject
    {
        /// <summary>
        /// 消费最低金额限制
        /// </summary>
        [XmlElement("floor_amount")]
        public Amount FloorAmount { get; set; }

        /// <summary>
        /// 增品说明
        /// </summary>
        [XmlElement("gift")]
        public string Gift { get; set; }
    }
}
