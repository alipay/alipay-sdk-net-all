using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehServiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class VehServiceItem : AopObject
    {
        /// <summary>
        /// 活动信息列表
        /// </summary>
        [XmlElement("activity_items")]
        public VehActivityItem ActivityItems { get; set; }

        /// <summary>
        /// key属性的描述信息 支付宝支付(ALI_PAY)、 在线缴费(ONLINE_PAY)、 活动(ACTIVITY)
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支持的服务KEY ALI_PAY(支付宝支付)、 ONLINE_PAY(在线缴费)、 ACTIVITY(活动)
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
