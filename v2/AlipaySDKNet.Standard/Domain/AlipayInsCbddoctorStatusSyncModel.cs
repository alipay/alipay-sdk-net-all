using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsCbddoctorStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCbddoctorStatusSyncModel : AopObject
    {
        /// <summary>
        /// 医院内部分配给医生并且提前录入到蚂蚁系统内的工号，用于唯一标识一位医生
        /// </summary>
        [XmlElement("inst_doctor_id")]
        public string InstDoctorId { get; set; }

        /// <summary>
        /// 分配给互医的机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 对医生执行的状态操作 ONLINE-上线 OFFLINE-下线
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }
    }
}
