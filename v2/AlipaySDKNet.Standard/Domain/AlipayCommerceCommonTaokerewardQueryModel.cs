using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTaokerewardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTaokerewardQueryModel : AopObject
    {
        /// <summary>
        /// 淘客的支付宝账号
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 淘客的支付宝openId
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 淘客领取的任务的任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }
    }
}
