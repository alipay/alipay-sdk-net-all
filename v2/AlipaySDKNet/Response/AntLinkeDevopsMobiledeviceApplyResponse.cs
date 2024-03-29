using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntLinkeDevopsMobiledeviceApplyResponse.
    /// </summary>
    public class AntLinkeDevopsMobiledeviceApplyResponse : AopResponse
    {
        /// <summary>
        /// access_token+唯一+ws接口使用的鉴权信息+结果返回
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// device_id+唯一+设备id信息+用来标识设备的唯一键
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备信息+唯一+租用展示的请求参数+返回结果
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// device_status+唯一+设备状态信息+返回参数
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// expire_time+唯一+强制过期时间+结果返回
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// image_info+唯一+镜像信息+结果信息
        /// </summary>
        [XmlElement("image_info")]
        public string ImageInfo { get; set; }

        /// <summary>
        /// remote_port+唯一+远端请求的端口信息+返回结果
        /// </summary>
        [XmlElement("remote_port")]
        public string RemotePort { get; set; }
    }
}
