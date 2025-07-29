using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcMedConsultResult Data Structure.
    /// </summary>
    [Serializable]
    public class RcMedConsultResult : AopObject
    {
        /// <summary>
        /// 素问医疗信息咨询结果
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("consult_item")]
        public List<ConsultItem> ItemList { get; set; }
    }
}
