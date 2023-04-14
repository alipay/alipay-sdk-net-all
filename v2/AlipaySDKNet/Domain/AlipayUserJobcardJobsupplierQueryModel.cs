using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserJobcardJobsupplierQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserJobcardJobsupplierQueryModel : AopObject
    {
        /// <summary>
        /// 职位供应商code
        /// </summary>
        [XmlElement("job_supplier_code")]
        public string JobSupplierCode { get; set; }

        /// <summary>
        /// 支付宝用户user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
