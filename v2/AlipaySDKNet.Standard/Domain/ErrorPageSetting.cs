using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ErrorPageSetting Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorPageSetting : AopObject
    {
        /// <summary>
        /// 404错误页面在静态站点的文件路径，不能以 / 开头
        /// </summary>
        [XmlElement("error_page_404")]
        public string ErrorPage404 { get; set; }
    }
}
