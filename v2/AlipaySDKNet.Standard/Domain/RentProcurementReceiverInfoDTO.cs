using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementReceiverInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementReceiverInfoDTO : AopObject
    {
        /// <summary>
        /// 收货人身份证号（用于顺丰签收面单）
        /// </summary>
        [XmlElement("receiver_id_card_no")]
        public string ReceiverIdCardNo { get; set; }
    }
}
