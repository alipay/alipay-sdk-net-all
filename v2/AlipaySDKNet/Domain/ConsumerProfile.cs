using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerProfile Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerProfile : AopObject
    {
        /// <summary>
        /// 消费者画像，包含各年龄段消费者人群占比， 性别占比、复购次数占比等
        /// </summary>
        [XmlElement("consumer_profile")]
        public string ConsumerProfile_ { get; set; }
    }
}
