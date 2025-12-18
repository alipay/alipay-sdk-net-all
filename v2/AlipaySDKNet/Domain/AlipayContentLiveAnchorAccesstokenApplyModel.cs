using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveAnchorAccesstokenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveAnchorAccesstokenApplyModel : AopObject
    {
        /// <summary>
        /// 当action=REFRESH时，必须传入原access_token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 生成：CREATE 删除：DELETE 刷新：REFRESH 
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 主播的生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
