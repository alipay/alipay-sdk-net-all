using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerTransdataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerTransdataSyncResponse : AopResponse
    {
        /// <summary>
        /// 数据执行行数
        /// </summary>
        [XmlElement("excute_lines")]
        public string ExcuteLines { get; set; }

        /// <summary>
        /// 执行结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
