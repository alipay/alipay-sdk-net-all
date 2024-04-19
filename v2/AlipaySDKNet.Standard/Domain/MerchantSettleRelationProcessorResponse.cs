using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSettleRelationProcessorResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSettleRelationProcessorResponse : AopObject
    {
        /// <summary>
        /// 分账比例
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 分账接收方账号
        /// </summary>
        [XmlElement("trans_in_account")]
        public string TransInAccount { get; set; }

        /// <summary>
        /// 分账接收方ID
        /// </summary>
        [XmlElement("trans_in_id")]
        public string TransInId { get; set; }

        /// <summary>
        /// 分账接收方名称
        /// </summary>
        [XmlElement("trans_in_name")]
        public string TransInName { get; set; }

        /// <summary>
        /// 分账类型
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 分账出资方账号
        /// </summary>
        [XmlElement("trans_out_account")]
        public string TransOutAccount { get; set; }

        /// <summary>
        /// 分账出资方ID
        /// </summary>
        [XmlElement("trans_out_id")]
        public string TransOutId { get; set; }
    }
}
