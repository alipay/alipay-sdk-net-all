using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollParticipant : AopObject
    {
        /// <summary>
        /// 调用方自定义的外部商户编号，可以为空
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }

        /// <summary>
        /// 报名操作返回的失败原因，入参无须填写！
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 参与类型，支持PARTNER_ID 、LOGON_ID等
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 类型对应值,传参也不他
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
