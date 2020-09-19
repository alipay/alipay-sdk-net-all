using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceConsultResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceConsultResponse : AopResponse
    {
        /// <summary>
        /// 设备关联数据
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("device_relation_data")]
        public List<DeviceRelationData> Result { get; set; }
    }
}
