using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileBody Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileBody : AopObject
    {
        /// <summary>
        /// 核销流水集合
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("china_mobile_verification_sync_data")]
        public List<ChinaMobileVerificationSyncData> Data { get; set; }

        /// <summary>
        /// 权益方的核销流水，即每一次发生核销记录的唯一标识 1、若核销流水撤销标识=0（正常核销），此值唯一，系统将做幂等校验 2、若核销流水撤销标识=1（核销作废），此值需为本次需要作废的那一笔正常核销流水的流水号。
        /// </summary>
        [XmlElement("reco_id")]
        public string RecoId { get; set; }

        /// <summary>
        /// 该值是由权益运营管理平台分配，同channelCode
        /// </summary>
        [XmlElement("rights_id")]
        public string RightsId { get; set; }

        /// <summary>
        /// 0:正常核销;1-核销记录作废(即返销，用户退单,券码退回到用户账户) 。为空则默认0
        /// </summary>
        [XmlElement("verification_cancel_flag")]
        public long VerificationCancelFlag { get; set; }

        /// <summary>
        /// 0:后向同步，1:实时流水同步 本期可以暂时只考虑0-后向同步
        /// </summary>
        [XmlElement("verification_type")]
        public long VerificationType { get; set; }
    }
}
