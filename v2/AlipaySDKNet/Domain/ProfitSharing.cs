using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProfitSharing Data Structure.
    /// </summary>
    [Serializable]
    public class ProfitSharing : AopObject
    {
        /// <summary>
        /// 参与退分账的目标支付宝账号，长度16位纯数字
        /// </summary>
        [XmlElement("alloc_account")]
        public string AllocAccount { get; set; }

        /// <summary>
        /// 退分账金额，单元元
        /// </summary>
        [XmlElement("alloc_amount")]
        public string AllocAmount { get; set; }
    }
}
