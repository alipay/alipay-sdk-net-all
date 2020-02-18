using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillSendExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillSendExtInfo : AopObject
    {
        /// <summary>
        /// 分账金额
        /// </summary>
        [XmlElement("royalty_amount")]
        public string RoyaltyAmount { get; set; }

        /// <summary>
        /// 2088xxx
        /// </summary>
        [XmlElement("trans_in_pid")]
        public string TransInPid { get; set; }
    }
}
