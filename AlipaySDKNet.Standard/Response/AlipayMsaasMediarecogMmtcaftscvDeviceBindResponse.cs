using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvDeviceBindResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvDeviceBindResponse : AopResponse
    {
        /// <summary>
        /// 设备注册是否成功
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
