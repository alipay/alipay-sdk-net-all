using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAppauthQueryModel : AopObject
    {
        /// <summary>
        /// 商家小程序APPID
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 请求分页页面
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 请求分页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
