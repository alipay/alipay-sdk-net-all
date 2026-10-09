using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OBContractDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OBContractDTO : AopObject
    {
        /// <summary>
        /// bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商机编码
        /// </summary>
        [XmlElement("lead_no")]
        public string LeadNo { get; set; }

        /// <summary>
        /// 维保结束时间
        /// </summary>
        [XmlElement("ma_end_time")]
        public string MaEndTime { get; set; }

        /// <summary>
        /// 维保开始时间
        /// </summary>
        [XmlElement("ma_start_time")]
        public string MaStartTime { get; set; }
    }
}
