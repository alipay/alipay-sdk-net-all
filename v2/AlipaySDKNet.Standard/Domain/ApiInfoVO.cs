using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ApiInfoVO : AopObject
    {
        /// <summary>
        /// 用于查询应用已添加前台产品信息的接口
        /// </summary>
        [XmlElement("api_desc")]
        public string ApiDesc { get; set; }

        /// <summary>
        /// 接口英文名称
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }
    }
}
