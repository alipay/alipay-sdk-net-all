using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAshieldHardeningtaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAshieldHardeningtaskSubmitModel : AopObject
    {
        /// <summary>
        /// 是否开启assets加固，1为开启，其他为关闭
        /// </summary>
        [XmlElement("assets_protect")]
        public string AssetsProtect { get; set; }

        /// <summary>
        /// assets加固配置，多个用逗号分隔
        /// </summary>
        [XmlElement("assets_protect_config")]
        public string AssetsProtectConfig { get; set; }

        /// <summary>
        /// 是否开启对生命周期函数进行java2jni保护，1为开启，其他为关闭
        /// </summary>
        [XmlElement("enable_life_func")]
        public string EnableLifeFunc { get; set; }

        /// <summary>
        /// 文件上传OSS后地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// java2cjni配置文件
        /// </summary>
        [XmlArray("javatoc_jni_config")]
        [XmlArrayItem("class_method_config")]
        public List<ClassMethodConfig> JavatocJniConfig { get; set; }

        /// <summary>
        /// 运行时保护配置
        /// </summary>
        [XmlElement("runtime_protect_config")]
        public RuntimeProtectConfig RuntimeProtectConfig { get; set; }

        /// <summary>
        /// 是否开启so加固，1为开启，其他为关闭
        /// </summary>
        [XmlElement("so_protect")]
        public string SoProtect { get; set; }

        /// <summary>
        /// so加固配置，多个用逗号分隔
        /// </summary>
        [XmlElement("so_protect_config")]
        public string SoProtectConfig { get; set; }
    }
}
