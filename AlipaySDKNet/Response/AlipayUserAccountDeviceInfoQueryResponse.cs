using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountDeviceInfoQueryResponse.
    /// </summary>
    public class AlipayUserAccountDeviceInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 满足投放条件的简要设备信息
        /// </summary>
        [XmlArray("device_infos")]
        [XmlArrayItem("device_result_info")]
        public List<DeviceResultInfo> DeviceInfos { get; set; }

        /// <summary>
        /// 设备类型，如：IDFA、IMEI、MOBILE等
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备id的加密方式，如没有加密，可以不传。一般sha256即可满足需求，如其他方式，请和支付宝技术支持联系
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
