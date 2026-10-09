using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthEntryUserBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrhealthEntryUserBatchqueryModel : AopObject
    {
        /// <summary>
        /// data_key用于校验供应商的权限，每一个接入系统的供应商会有唯一的该参数，供应商来对接时蚂蚁生成唯一参数线下给到供应商侧，供应商需要传入来校验身份
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }
    }
}
