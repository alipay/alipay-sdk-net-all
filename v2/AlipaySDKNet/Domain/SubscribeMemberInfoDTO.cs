using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscribeMemberInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubscribeMemberInfoDTO : AopObject
    {
        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        [XmlElement("left_times")]
        public string LeftTimes { get; set; }

        /// <summary>
        /// 订阅时间
        /// </summary>
        [XmlElement("subscribe_date")]
        public string SubscribeDate { get; set; }

        /// <summary>
        /// 套餐id
        /// </summary>
        [XmlElement("subscribe_package_id")]
        public string SubscribePackageId { get; set; }

        /// <summary>
        /// 套餐类型
        /// </summary>
        [XmlElement("subscribe_package_type")]
        public string SubscribePackageType { get; set; }

        /// <summary>
        /// 订阅次数
        /// </summary>
        [XmlElement("subscribe_times")]
        public string SubscribeTimes { get; set; }
    }
}
