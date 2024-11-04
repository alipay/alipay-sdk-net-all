using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudHeyagentApplyModel : AopObject
    {
        /// <summary>
        /// 云渲染启动的小程序ID
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 业务场景编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 云渲染启动模式
        /// </summary>
        [XmlElement("boot_type")]
        public string BootType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
