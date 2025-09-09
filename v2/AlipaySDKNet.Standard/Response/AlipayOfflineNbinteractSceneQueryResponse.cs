using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineNbinteractSceneQueryResponse.
    /// </summary>
    public class AlipayOfflineNbinteractSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备互动链接绑定状态
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 设备互动链接操作绑定的时间
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 碰一下互动跳转链接所属类型
        /// </summary>
        [XmlElement("url_type")]
        public string UrlType { get; set; }
    }
}
