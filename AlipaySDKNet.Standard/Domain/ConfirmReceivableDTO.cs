using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConfirmReceivableDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ConfirmReceivableDTO : AopObject
    {
        /// <summary>
        /// 确认模式，支持ONE_TIME和BY_STRATEGY
        /// </summary>
        [XmlElement("confirm_model")]
        public string ConfirmModel { get; set; }

        /// <summary>
        /// 请求时的业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 应收确认单号
        /// </summary>
        [XmlElement("receivable_no")]
        public string ReceivableNo { get; set; }
    }
}
