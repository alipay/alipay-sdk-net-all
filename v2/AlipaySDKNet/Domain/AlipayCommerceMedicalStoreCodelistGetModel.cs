using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreCodelistGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreCodelistGetModel : AopObject
    {
        /// <summary>
        /// 每次获取数据限制的最大条数，举例：传100时，则在数据量满足的情况下，单次最多返回100条数据
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 用于分批获取门店编码的偏移量；举例：每一次调用接口获取100条，则第一次传0，第二次传100，第N次传（N-1）*100
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }
    }
}
