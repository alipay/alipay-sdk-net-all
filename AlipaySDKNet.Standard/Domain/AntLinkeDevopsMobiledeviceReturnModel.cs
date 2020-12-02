using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntLinkeDevopsMobiledeviceReturnModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntLinkeDevopsMobiledeviceReturnModel : AopObject
    {
        /// <summary>
        /// device_id+唯一+设备释放对象+antdevops.mobiledevice.get接口返回参数+必须先占用才能释放
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// access_host+唯一+释放设备的host信息+apply结果返回结果
        /// </summary>
        [XmlElement("remote_host")]
        public string RemoteHost { get; set; }
    }
}
