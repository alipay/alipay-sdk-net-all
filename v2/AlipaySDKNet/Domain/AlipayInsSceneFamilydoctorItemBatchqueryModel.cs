using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneFamilydoctorItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneFamilydoctorItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 服务合约号
        /// </summary>
        [XmlElement("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 病症列表
        /// </summary>
        [XmlArray("disease_name_list")]
        [XmlArrayItem("string")]
        public List<string> DiseaseNameList { get; set; }

        /// <summary>
        /// 是否急诊，true急诊，false非急诊
        /// </summary>
        [XmlElement("emergency")]
        public bool Emergency { get; set; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [XmlArray("general_name_list")]
        [XmlArrayItem("string")]
        public List<string> GeneralNameList { get; set; }
    }
}
