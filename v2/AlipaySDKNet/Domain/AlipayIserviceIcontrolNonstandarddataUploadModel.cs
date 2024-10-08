using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolNonstandarddataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolNonstandarddataUploadModel : AopObject
    {
        /// <summary>
        /// 非标准数据内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 小二的星云id
        /// </summary>
        [XmlElement("nebula_id")]
        public string NebulaId { get; set; }

        /// <summary>
        /// 外部数据唯一标识
        /// </summary>
        [XmlElement("out_biz_code")]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
