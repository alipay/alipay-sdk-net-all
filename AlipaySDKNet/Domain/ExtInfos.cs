using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtInfos Data Structure.
    /// </summary>
    [Serializable]
    public class ExtInfos : AopObject
    {
        /// <summary>
        /// 唤起鉴权的页面类型；DETAIL表示商详页
        /// </summary>
        [XmlElement("req_from_page")]
        public string ReqFromPage { get; set; }
    }
}
