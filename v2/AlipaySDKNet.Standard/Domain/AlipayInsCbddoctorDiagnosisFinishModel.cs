using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsCbddoctorDiagnosisFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCbddoctorDiagnosisFinishModel : AopObject
    {
        /// <summary>
        /// 蚂蚁服务单编号
        /// </summary>
        [XmlElement("service_order_id")]
        public string ServiceOrderId { get; set; }
    }
}
