using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisOperationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseRedisOperationQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 过滤内容
        /// </summary>
        [XmlElement("filter_content")]
        public string FilterContent { get; set; }

        /// <summary>
        /// 任务类型，执行状态等, 0:不需要过滤条件，1:按照任务类型，2:任务状态
        /// </summary>
        [XmlElement("filter_type")]
        public long FilterType { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [XmlElement("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 机房
        /// </summary>
        [XmlElement("zone")]
        public string Zone { get; set; }
    }
}
