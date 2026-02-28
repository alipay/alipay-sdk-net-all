using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TempBusinessExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TempBusinessExtInfo : AopObject
    {
        /// <summary>
        /// 服务商调用接口为商家添加申请物料信息时，可以指定商家的uid信息
        /// </summary>
        [XmlElement("custom_ext_info_str")]
        public string CustomExtInfoStr { get; set; }
    }
}
