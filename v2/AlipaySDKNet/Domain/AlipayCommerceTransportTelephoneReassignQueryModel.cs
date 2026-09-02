using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTelephoneReassignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTelephoneReassignQueryModel : AopObject
    {
        /// <summary>
        /// 用户签约协议号，传入时必须与记录 usage_agreementid 完全一致，不一致判不命中
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 查询是否疑似二次放号的目标用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pid_list")]
        [XmlArrayItem("string")]
        public List<string> PidList { get; set; }

        /// <summary>
        /// 查询是否疑似二次放号的目标用户id
        /// </summary>
        [XmlElement("target_uid")]
        public string TargetUid { get; set; }
    }
}
