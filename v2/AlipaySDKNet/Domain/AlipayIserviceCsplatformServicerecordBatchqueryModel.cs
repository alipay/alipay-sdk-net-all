using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsplatformServicerecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsplatformServicerecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
