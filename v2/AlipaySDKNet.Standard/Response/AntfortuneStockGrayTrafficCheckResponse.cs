using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockGrayTrafficCheckResponse.
    /// </summary>
    public class AntfortuneStockGrayTrafficCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否通过校验（发布前未配灰度流量=true）
        /// </summary>
        [XmlElement("check_passed")]
        public bool CheckPassed { get; set; }

        /// <summary>
        /// 命中说明单条字符串（提供方组装好场景/模式/配置摘要，多点命中分号分隔），未命中或校验失败时为空
        /// </summary>
        [XmlElement("hit_message")]
        public string HitMessage { get; set; }
    }
}
