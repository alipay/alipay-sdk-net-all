using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceOpenapiallTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceOpenapiallTransferModel : AopObject
    {
        /// <summary>
        /// 接口名#方法名
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// JSON序列化后的入参
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 星云系统用户id，1088码
        /// </summary>
        [XmlElement("ur_id")]
        public string UrId { get; set; }
    }
}
