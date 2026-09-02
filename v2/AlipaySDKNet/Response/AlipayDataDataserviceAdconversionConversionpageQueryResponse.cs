using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdconversionConversionpageQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdconversionConversionpageQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 转化信息
        /// </summary>
        [XmlElement("list")]
        public AdConversion List { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 返回总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
