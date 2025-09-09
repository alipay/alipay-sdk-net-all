using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpInfoSearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpInfoSearchQueryModel : AopObject
    {
        /// <summary>
        /// 请输入标准工商注册的企业名称，在此之外的特殊不允许输入
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 分页用参数，代表请求结果的起始位置，默认1
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页用参数，表示需要返回的结果条数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
