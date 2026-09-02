using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrugItem Data Structure.
    /// </summary>
    [Serializable]
    public class DrugItem : AopObject
    {
        /// <summary>
        /// 用药叮嘱
        /// </summary>
        [XmlElement("drug_notice")]
        public string DrugNotice { get; set; }

        /// <summary>
        /// 每次用药剂量，剂量+剂量单位 + "/次",如1片/次，3ml/次
        /// </summary>
        [XmlElement("drugdosage")]
        public string Drugdosage { get; set; }

        /// <summary>
        /// 用药时间
        /// </summary>
        [XmlElement("drugduration")]
        public string Drugduration { get; set; }

        /// <summary>
        /// 用药频次，如一天一次，一天三次等
        /// </summary>
        [XmlElement("drugfrequency")]
        public string Drugfrequency { get; set; }

        /// <summary>
        /// 药品名
        /// </summary>
        [XmlElement("drugname")]
        public string Drugname { get; set; }

        /// <summary>
        /// 开药数量+单位，如7盒、8包、6瓶等
        /// </summary>
        [XmlElement("drugquantity")]
        public string Drugquantity { get; set; }

        /// <summary>
        /// 药品规格包装，如1.5mg*10片/包,5mg*28片/盒,50mg*10s*2板等
        /// </summary>
        [XmlElement("drugspecification")]
        public string Drugspecification { get; set; }

        /// <summary>
        /// 用药，药品用法
        /// </summary>
        [XmlElement("druguse")]
        public string Druguse { get; set; }
    }
}
