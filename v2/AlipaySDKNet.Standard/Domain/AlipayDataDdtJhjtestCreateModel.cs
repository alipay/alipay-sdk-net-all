using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDdtJhjtestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDdtJhjtestCreateModel : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("com_a")]
        public PubNestPub ComA { get; set; }

        /// <summary>
        /// 123456222
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 123456
        /// </summary>
        [XmlElement("id_openid")]
        public string IdOpenid { get; set; }

        /// <summary>
        /// 老链路修改a_test_a老链路修改a_test_a老链路修改a_test_a 当前字段已废弃(废弃了的)
        /// </summary>
        [XmlElement("input_a")]
        public string InputA { get; set; }

        /// <summary>
        /// 描述很长描述很长描述很长描述很长描述很长描述很长描述很长
        /// </summary>
        [XmlElement("input_b")]
        public string InputB { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_c")]
        public string InputC { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_d")]
        public string InputD { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_ee")]
        public string InputEe { get; set; }

        /// <summary>
        /// jhj测试子场景（修改）jhj测试子场景（修改）jhj测试子场景（修改）jhj测试子场景（修改）jhj测试子场景（修改）
        /// </summary>
        [XmlElement("map_a_openid")]
        public string MapAOpenid { get; set; }
    }
}
