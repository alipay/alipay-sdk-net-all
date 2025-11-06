using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenProductionprogressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenProductionprogressQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 流水id，通过调用alipay.open.sp.ncoilopen.reference.create接口返回值中获取reference_id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
