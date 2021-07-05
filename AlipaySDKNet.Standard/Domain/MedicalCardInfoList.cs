using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalCardInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalCardInfoList : AopObject
    {
        /// <summary>
        /// 参保地列表
        /// </summary>
        [XmlElement("insured_cities")]
        public MedicalInsuredCityList InsuredCities { get; set; }

        /// <summary>
        /// 参保状态
        /// </summary>
        [XmlElement("insured_status")]
        public string InsuredStatus { get; set; }

        /// <summary>
        /// 持卡人与当前UID账户关系
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 绑卡激活状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
