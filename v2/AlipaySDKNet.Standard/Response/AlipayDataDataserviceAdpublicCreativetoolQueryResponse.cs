using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdpublicCreativetoolQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdpublicCreativetoolQueryResponse : AopResponse
    {
        /// <summary>
        /// 生活号列表值
        /// </summary>
        [XmlElement("data_list")]
        public UserPublicQueryResponse DataList { get; set; }

        /// <summary>
        /// 返回搜索出的素材总个数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
