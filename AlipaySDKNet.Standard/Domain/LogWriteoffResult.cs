using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogWriteoffResult Data Structure.
    /// </summary>
    [Serializable]
    public class LogWriteoffResult : AopObject
    {
        /// <summary>
        /// 冲销业务失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 资金流水平台驱动业务系统进行冲销结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 冲销凭证ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
