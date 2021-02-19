using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasDevicebindApplyResponse.
    /// </summary>
    public class AlipayOpenIotbpaasDevicebindApplyResponse : AopResponse
    {
        /// <summary>
        /// 绑定信息
        /// </summary>
        [XmlElement("bind_info")]
        public IoTBPaaSDeviceApplyBindInfo BindInfo { get; set; }

        /// <summary>
        /// 绑定状态：1、已绑定；2、未绑定；3、绑定中；4、绑定失败；5、无效token；
        /// </summary>
        [XmlElement("bind_status")]
        public long BindStatus { get; set; }

        /// <summary>
        /// 绑定token，用于轮询绑定状态
        /// </summary>
        [XmlElement("bind_token")]
        public string BindToken { get; set; }

        /// <summary>
        /// 绑定URL，用于引导商户进行绑定操作
        /// </summary>
        [XmlElement("bind_url")]
        public string BindUrl { get; set; }
    }
}
