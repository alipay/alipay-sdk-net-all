using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwLibraryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }
    }
}
