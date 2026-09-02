using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecipeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecipeInfo : AopObject
    {
        /// <summary>
        /// 诊断
        /// </summary>
        [XmlElement("diagnosis")]
        public string Diagnosis { get; set; }

        /// <summary>
        /// 医生提醒
        /// </summary>
        [XmlElement("doc_notice")]
        public string DocNotice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("druglist")]
        [XmlArrayItem("drug_item")]
        public List<DrugItem> Druglist { get; set; }

        /// <summary>
        /// 患者年龄，如XX岁XX月；
        /// </summary>
        [XmlElement("patientage")]
        public string Patientage { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        [XmlElement("patientsex")]
        public string Patientsex { get; set; }

        /// <summary>
        /// 患者体重，单位kg
        /// </summary>
        [XmlElement("patientweight")]
        public string Patientweight { get; set; }

        /// <summary>
        /// 业务方传入审核的处方id
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }

        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("recipe_status")]
        public string RecipeStatus { get; set; }

        /// <summary>
        /// 处方开具时间
        /// </summary>
        [XmlElement("recipe_time")]
        public string RecipeTime { get; set; }

        /// <summary>
        /// 处方类型
        /// </summary>
        [XmlElement("recipedrugtype")]
        public string Recipedrugtype { get; set; }

        /// <summary>
        /// 拒绝修改原因
        /// </summary>
        [XmlElement("refusemodifyreason")]
        public string Refusemodifyreason { get; set; }
    }
}
