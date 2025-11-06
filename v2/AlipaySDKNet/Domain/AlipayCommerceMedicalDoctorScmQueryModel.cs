using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorScmQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctorScmQueryModel : AopObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 医生id列表
        /// </summary>
        [XmlArray("doctor_id_list")]
        [XmlArrayItem("string")]
        public List<string> DoctorIdList { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
