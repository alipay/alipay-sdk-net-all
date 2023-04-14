using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneYebEntityequityVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneYebEntityequityVerifyModel : AopObject
    {
        /// <summary>
        /// 阿里云回调接口应用ID, appid这个名称是阿里云定义的
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 阿里云回调接口信息，info这个名称是阿里云定义的
        /// </summary>
        [XmlElement("info")]
        public LinkMallCallBackInfo Info { get; set; }

        /// <summary>
        /// 阿里云回调接口信息签名，signature这个名称是阿里云定义的
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }
    }
}
