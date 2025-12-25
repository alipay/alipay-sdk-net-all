using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentHdfpatientSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentHdfpatientSyncModel : AopObject
    {
        /// <summary>
        /// AQ用户ID
        /// </summary>
        [XmlElement("aq_u_id")]
        public string AqUId { get; set; }

        /// <summary>
        /// 出生日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("birth_day")]
        public string BirthDay { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 就诊人ID
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// SELF(0, "本人"),     FAMILY(1, "家庭成员"),     RELATIVE(2, "亲戚"),     FRIEND(3, "朋友"),     OTHER(4, "其他");
        /// </summary>
        [XmlElement("relation")]
        public long Relation { get; set; }

        /// <summary>
        /// 性别，0-女 1-男 2-未知
        /// </summary>
        [XmlElement("sex")]
        public long Sex { get; set; }
    }
}
