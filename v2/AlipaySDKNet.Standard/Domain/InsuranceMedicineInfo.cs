using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuranceMedicineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuranceMedicineInfo : AopObject
    {
        /// <summary>
        /// 药品总价，单位：元，保留2位小数
        /// </summary>
        [XmlElement("medicine_amount")]
        public string MedicineAmount { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("medicine_name")]
        public string MedicineName { get; set; }

        /// <summary>
        /// 药品数量，单位：克、钱、盒、支、粒，保留2位小数
        /// </summary>
        [XmlElement("medicine_num")]
        public string MedicineNum { get; set; }

        /// <summary>
        /// 药品价格，单位：元，保留2位小数
        /// </summary>
        [XmlElement("medicine_price")]
        public string MedicinePrice { get; set; }

        /// <summary>
        /// 药品规格，描述药品规格说明，单位：盒、次、处方、非处方等
        /// </summary>
        [XmlElement("medicine_specification")]
        public string MedicineSpecification { get; set; }
    }
}
