using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialShopstaffBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialShopstaffBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 门店店员列表
        /// </summary>
        [XmlArray("staffs")]
        [XmlArrayItem("dental_archives_shop_staff")]
        public List<DentalArchivesShopStaff> Staffs { get; set; }
    }
}
