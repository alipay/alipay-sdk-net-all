using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrugInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class DrugInfoVO : AopObject
    {
        /// <summary>
        /// 数量单位盒、瓶、支,如2
        /// </summary>
        [XmlElement("drug_cnt")]
        public long DrugCnt { get; set; }

        /// <summary>
        /// 75mg*30粒
        /// </summary>
        [XmlElement("drug_spec")]
        public string DrugSpec { get; set; }

        /// <summary>
        /// 购买单位,取值有盒、瓶、支等
        /// </summary>
        [XmlElement("drug_unit")]
        public string DrugUnit { get; set; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [XmlElement("generic_name")]
        public string GenericName { get; set; }

        /// <summary>
        /// 一日三餐,50克每餐
        /// </summary>
        [XmlElement("usage_dosage")]
        public string UsageDosage { get; set; }
    }
}
