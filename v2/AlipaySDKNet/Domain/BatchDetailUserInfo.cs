using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchDetailUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BatchDetailUserInfo : AopObject
    {
        /// <summary>
        /// 转入方主体业务类型,待结算:unsettled,已结算:settled
        /// </summary>
        [XmlElement("trans_in_entity_biz_type")]
        public string TransInEntityBizType { get; set; }

        /// <summary>
        /// 转入方(分账对手方/结算主体)id，传具体smid; 本次支持异名结算,需要将转入方id更改为预期异名结算的smid
        /// </summary>
        [XmlElement("trans_in_entity_id")]
        public string TransInEntityId { get; set; }

        /// <summary>
        /// 转入方id类型,传smid类型,本次传4
        /// </summary>
        [XmlElement("trans_in_entity_id_type")]
        public string TransInEntityIdType { get; set; }

        /// <summary>
        /// 转出方主体业务类型,待结算:unsettled,已结算:settled
        /// </summary>
        [XmlElement("trans_out_entity_biz_type")]
        public string TransOutEntityBizType { get; set; }

        /// <summary>
        /// 转出方(分账出资方/结算主体)id,传具体smid
        /// </summary>
        [XmlElement("trans_out_entity_id")]
        public string TransOutEntityId { get; set; }

        /// <summary>
        /// 转出方id类型,传smid类型,本次传4
        /// </summary>
        [XmlElement("trans_out_entity_id_type")]
        public string TransOutEntityIdType { get; set; }
    }
}
