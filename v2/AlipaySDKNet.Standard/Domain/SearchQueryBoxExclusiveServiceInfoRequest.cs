using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchQueryBoxExclusiveServiceInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchQueryBoxExclusiveServiceInfoRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 服务类型标识符：SP_MINI_APP/SP_PUBLIC_APP（小程序/生活号）
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
