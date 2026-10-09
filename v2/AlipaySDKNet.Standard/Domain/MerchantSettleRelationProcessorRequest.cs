using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSettleRelationProcessorRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSettleRelationProcessorRequest : AopObject
    {
        /// <summary>
        /// 分账比例，范围在0-30之间，可包含小数点后两位
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 分账接收方账号
        /// </summary>
        [XmlElement("trans_in_account")]
        public string TransInAccount { get; set; }

        /// <summary>
        /// 分账接收方名称
        /// </summary>
        [XmlElement("trans_in_name")]
        public string TransInName { get; set; }
    }
}
