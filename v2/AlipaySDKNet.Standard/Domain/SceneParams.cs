using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneParams Data Structure.
    /// </summary>
    [Serializable]
    public class SceneParams : AopObject
    {
        /// <summary>
        /// 人脸接入必传，身份核验授权authFlag，R仅授权人脸认证结果，A为认证结果和人脸图像
        /// </summary>
        [XmlElement("auth_flag")]
        public string AuthFlag { get; set; }

        /// <summary>
        /// 核身完成后的回调类型枚举
        /// </summary>
        [XmlElement("call_back_action_code")]
        public string CallBackActionCode { get; set; }

        /// <summary>
        /// 环境参数，获取的客户端环境信息（仅对人脸、指纹等依赖设备硬件的核身方式）。客户端通过jsapi获取    ant.call('verifyIdentity', {       action: 'getEnvData',      actionInfo: '',     }, function (result) {        console.log(result.actionResult);     });
        /// </summary>
        [XmlElement("env_data")]
        public string EnvData { get; set; }

        /// <summary>
        /// 渲染形态，native或h5
        /// </summary>
        [XmlElement("render_group")]
        public string RenderGroup { get; set; }
    }
}
