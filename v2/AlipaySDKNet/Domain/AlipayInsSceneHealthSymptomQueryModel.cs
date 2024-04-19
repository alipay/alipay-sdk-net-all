using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthSymptomQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneHealthSymptomQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁合约单号
        /// </summary>
        [XmlElement("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 症状搜索关键词
        /// </summary>
        [XmlElement("symptom_search_keyword")]
        public string SymptomSearchKeyword { get; set; }
    }
}
