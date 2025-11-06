using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfappointmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfappointmentQueryModel : AopObject
    {
        /// <summary>
        /// 消息体
        /// </summary>
        [XmlElement("msgcontent")]
        public string Msgcontent { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
