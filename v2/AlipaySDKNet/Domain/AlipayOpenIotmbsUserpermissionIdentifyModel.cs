using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsUserpermissionIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsUserpermissionIdentifyModel : AopObject
    {
        /// <summary>
        /// 根据param_type输入参数值
        /// </summary>
        [XmlElement("param_id")]
        public string ParamId { get; set; }

        /// <summary>
        /// param_id的参数类型
        /// </summary>
        [XmlElement("param_type")]
        public string ParamType { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
