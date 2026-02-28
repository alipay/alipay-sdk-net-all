using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationMobileTagSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationMobileTagSyncModel : AopObject
    {
        /// <summary>
        /// 是否绑定了AI
        /// </summary>
        [XmlElement("bind_ai")]
        public bool BindAi { get; set; }

        /// <summary>
        /// 是否绑定了云回看
        /// </summary>
        [XmlElement("bind_replay")]
        public bool BindReplay { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 是否有设备
        /// </summary>
        [XmlElement("has_device")]
        public bool HasDevice { get; set; }

        /// <summary>
        /// 加密后的手机号
        /// </summary>
        [XmlElement("mobile_hash")]
        public string MobileHash { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
