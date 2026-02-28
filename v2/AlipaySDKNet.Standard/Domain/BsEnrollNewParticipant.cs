using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollNewParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollNewParticipant : AopObject
    {
        /// <summary>
        /// 报名拓展信息
        /// </summary>
        [XmlElement("ext_info")]
        public BsEnrollParticipantExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 外部商户编号
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }

        /// <summary>
        /// 参与类型，参与类型，支持PARTNER_ID 、LOGON_ID等
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 类型对应值，传入报名对象的返回值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
