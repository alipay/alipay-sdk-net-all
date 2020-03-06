using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardInstanceDO Data Structure.
    /// </summary>
    [Serializable]
    public class CardInstanceDO : AopObject
    {
        /// <summary>
        /// 小目标卡片Id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 用户获得卡片的当前星级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 卡片最大星级
        /// </summary>
        [XmlElement("max_level")]
        public long MaxLevel { get; set; }

        /// <summary>
        /// 小目标卡片名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
