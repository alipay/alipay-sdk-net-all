using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorAccountingResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorAccountingResponse : AopObject
    {
        /// <summary>
        /// 医生核算明细记录的主键
        /// </summary>
        [XmlElement("doctor_accounting_detail_no")]
        public string DoctorAccountingDetailNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("event_flow_no")]
        [XmlArrayItem("string")]
        public List<string> EventFlowNo { get; set; }
    }
}
