using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryCampBatchqueryModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
