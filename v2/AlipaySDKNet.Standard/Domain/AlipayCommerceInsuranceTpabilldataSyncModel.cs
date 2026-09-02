using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceInsuranceTpabilldataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceInsuranceTpabilldataSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tpa_bill_data_list")]
        [XmlArrayItem("tpa_bill_data_d_t_o")]
        public List<TpaBillDataDTO> TpaBillDataList { get; set; }

        /// <summary>
        /// TPA编号
        /// </summary>
        [XmlElement("tpa_id")]
        public string TpaId { get; set; }
    }
}
