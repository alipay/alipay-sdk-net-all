using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryModifyResponse : AopResponse
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
