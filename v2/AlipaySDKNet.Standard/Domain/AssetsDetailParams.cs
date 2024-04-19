using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetsDetailParams Data Structure.
    /// </summary>
    [Serializable]
    public class AssetsDetailParams : AopObject
    {
        /// <summary>
        /// 资产是否准入
        /// </summary>
        [XmlElement("admit")]
        public string Admit { get; set; }

        /// <summary>
        /// 免息券信息
        /// </summary>
        [XmlElement("int_free_info")]
        public string IntFreeInfo { get; set; }
    }
}
