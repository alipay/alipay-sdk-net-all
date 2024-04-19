using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthPrescriptionCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneHealthPrescriptionCheckModel : AopObject
    {
        /// <summary>
        /// 蚂蚁合约单号
        /// </summary>
        [XmlElement("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 问诊结论（结构化处方）
        /// </summary>
        [XmlElement("diagnosis")]
        public Diagnosis Diagnosis { get; set; }

        /// <summary>
        /// 问诊对话
        /// </summary>
        [XmlArray("dialogue_process")]
        [XmlArrayItem("dialogue_process")]
        public List<DialogueProcess> DialogueProcess { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }
    }
}
