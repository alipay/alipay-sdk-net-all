using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoCoilSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoCoilSetModel : AopObject
    {
        /// <summary>
        /// 线圈类型
        /// </summary>
        [XmlElement("coil_type")]
        public string CoilType { get; set; }

        /// <summary>
        /// 用户open id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页面自定义参数，不能包含中文字符，中文字符请用UTF-8格式进行URLEncoder.encode
        /// </summary>
        [XmlElement("page_params")]
        public string PageParams { get; set; }

        /// <summary>
        /// 线圈id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
