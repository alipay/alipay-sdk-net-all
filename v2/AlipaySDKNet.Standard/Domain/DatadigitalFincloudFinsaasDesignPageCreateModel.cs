using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDesignPageCreateModel : AopObject
    {
        /// <summary>
        /// 创建页面的信息
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
