using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTempQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenTempQueryModel : AopObject
    {
        /// <summary>
        /// 单条线圈数据唯一标识
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 流水id，通过调用alipay.open.sp.ncoilopen.reference.create接口返回值中获取reference_id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
