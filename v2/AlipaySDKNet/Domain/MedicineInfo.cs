using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineInfo : AopObject
    {
        /// <summary>
        /// yyy-MM-dd HH:mm:ss medicine_verified=（true）已核销时必传
        /// </summary>
        [XmlElement("consumed_time")]
        public string ConsumedTime { get; set; }

        /// <summary>
        /// 药名
        /// </summary>
        [XmlElement("medicine_name")]
        public string MedicineName { get; set; }

        /// <summary>
        /// 药品数量/ 件
        /// </summary>
        [XmlElement("medicine_num")]
        public long MedicineNum { get; set; }

        /// <summary>
        /// 药品核销状态：true-已核销 false-未核销
        /// </summary>
        [XmlElement("medicine_verified")]
        public bool MedicineVerified { get; set; }
    }
}
