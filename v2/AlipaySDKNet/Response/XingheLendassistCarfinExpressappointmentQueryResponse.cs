using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinExpressappointmentQueryResponse.
    /// </summary>
    public class XingheLendassistCarfinExpressappointmentQueryResponse : AopResponse
    {
        /// <summary>
        /// 预约时间列表
        /// </summary>
        [XmlElement("appointment_list")]
        public string AppointmentList { get; set; }
    }
}
