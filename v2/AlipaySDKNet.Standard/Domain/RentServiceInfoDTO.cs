using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentServiceInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentServiceInfoDTO : AopObject
    {
        /// <summary>
        /// 借贷专户ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 服务编号
        /// </summary>
        [XmlElement("service_no")]
        public string ServiceNo { get; set; }
    }
}
