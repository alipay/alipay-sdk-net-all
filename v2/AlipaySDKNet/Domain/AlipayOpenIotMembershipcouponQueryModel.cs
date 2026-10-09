using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotMembershipcouponQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotMembershipcouponQueryModel : AopObject
    {
        /// <summary>
        /// 小程序ID，来自于BPaaS注册的应用ID，取值通常和小程序的appId相同
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// ISV序列号，来自于ISV成员体系数据
        /// </summary>
        [XmlElement("membership_id")]
        public string MembershipId { get; set; }

        /// <summary>
        /// 服务码，来源于ISV自行配置，用于区分具体的服务类型
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备SN，与设备ID共同描述IoT设备信息
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
