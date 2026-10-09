using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLayerModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionLayerModifyModel : AopObject
    {
        /// <summary>
        /// 绑定配置
        /// </summary>
        [XmlArray("bindings")]
        [XmlArrayItem("layer_binding")]
        public List<LayerBinding> Bindings { get; set; }

        /// <summary>
        /// 小程序云应用APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }
    }
}
