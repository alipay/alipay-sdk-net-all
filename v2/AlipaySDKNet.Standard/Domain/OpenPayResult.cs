using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenPayResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPayResult : AopObject
    {
        /// <summary>
        /// 支付结构模块数组
        /// </summary>
        [XmlArray("modules")]
        [XmlArrayItem("open_pay_result_module")]
        public List<OpenPayResultModule> Modules { get; set; }
    }
}
