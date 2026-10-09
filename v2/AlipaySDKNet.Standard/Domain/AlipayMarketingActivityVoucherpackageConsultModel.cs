using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherpackageConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherpackageConsultModel : AopObject
    {
        /// <summary>
        /// 券包id列表
        /// </summary>
        [XmlArray("voucher_package_id_list")]
        [XmlArrayItem("string")]
        public List<string> VoucherPackageIdList { get; set; }
    }
}
