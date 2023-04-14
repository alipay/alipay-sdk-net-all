using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthDrugcatalogueBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneHealthDrugcatalogueBatchqueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁合约单号
        /// </summary>
        [XmlElement("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 疾病名称列表
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
        /// 药品通用名列表
        /// </summary>
        [XmlArray("general_name_list")]
        [XmlArrayItem("string")]
        public List<string> GeneralNameList { get; set; }

        /// <summary>
        /// 商品名称列表
        /// </summary>
        [XmlArray("item_name_list")]
        [XmlArrayItem("string")]
        public List<string> ItemNameList { get; set; }
    }
}
