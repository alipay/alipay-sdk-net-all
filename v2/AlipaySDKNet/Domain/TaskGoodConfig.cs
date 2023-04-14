using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskGoodConfig Data Structure.
    /// </summary>
    [Serializable]
    public class TaskGoodConfig : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("good_id")]
        public string GoodId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("good_name")]
        public string GoodName { get; set; }
    }
}
