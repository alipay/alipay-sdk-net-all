using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderExtendInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderExtendInfoVO : AopObject
    {
        /// <summary>
        /// 承诺发货时间
        /// </summary>
        [XmlElement("promised_send_time")]
        public string PromisedSendTime { get; set; }

        /// <summary>
        /// 定义参考 <a href="https://opendocs.alipay.com/mini/0dfcde" target="_blank">公域场景标识</a>
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 芝麻租赁频道联营订单标
        /// </summary>
        [XmlElement("union_rent_tag")]
        public string UnionRentTag { get; set; }
    }
}
