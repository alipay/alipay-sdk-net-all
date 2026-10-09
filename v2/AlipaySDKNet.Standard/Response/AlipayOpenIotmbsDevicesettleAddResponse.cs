using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsDevicesettleAddResponse.
    /// </summary>
    public class AlipayOpenIotmbsDevicesettleAddResponse : AopResponse
    {
        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 设备进件的结果，会返回每个进件的设备的处理结果
        /// </summary>
        [XmlArray("settle_results")]
        [XmlArrayItem("device_settle_applicant_result")]
        public List<DeviceSettleApplicantResult> SettleResults { get; set; }
    }
}
