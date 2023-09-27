using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateSalesgptOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateSalesgptOrderModifyModel : AopObject
    {
        /// <summary>
        /// 详细内容数据
        /// </summary>
        [XmlElement("content")]
        public OrderSubmitContent Content { get; set; }

        /// <summary>
        /// 请求接口名称
        /// </summary>
        [XmlElement("method_name")]
        public string MethodName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
