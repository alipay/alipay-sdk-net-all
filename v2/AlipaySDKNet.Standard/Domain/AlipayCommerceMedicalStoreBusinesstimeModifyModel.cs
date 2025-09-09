using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreBusinesstimeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreBusinesstimeModifyModel : AopObject
    {
        /// <summary>
        /// 门店营业时间
        /// </summary>
        [XmlArray("business_dates")]
        [XmlArrayItem("business_date_d_t_o")]
        public List<BusinessDateDTO> BusinessDates { get; set; }

        /// <summary>
        /// APP方门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
