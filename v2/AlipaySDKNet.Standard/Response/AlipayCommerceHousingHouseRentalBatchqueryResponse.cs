using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingHouseRentalBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceHousingHouseRentalBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("rent_house_model_d_t_o")]
        public List<RentHouseModelDTO> List { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总的数据大小，单位：条
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
