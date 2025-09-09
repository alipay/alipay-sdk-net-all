using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintUploadResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityVoiceprintUploadResponse : AopResponse
    {
        /// <summary>
        /// 当前设备数据
        /// </summary>
        [XmlElement("device_data")]
        public string DeviceData { get; set; }
    }
}
